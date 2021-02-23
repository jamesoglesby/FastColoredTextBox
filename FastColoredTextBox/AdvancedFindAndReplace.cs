using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace FastColoredTextBoxNS
{
    public partial class AdvancedFindAndReplace : Form
    {
        bool firstSearch = true;
        Place startPlace;
        FastColoredTextBox tb;

        public AdvancedFindAndReplace(FastColoredTextBox tb)
        {
            InitializeComponent();
            this.tb = tb;
        }

        private void AdvancedFindAndReplace_Load(object sender, EventArgs e)
        {
            //By defualt, disable the replace items
            btReplace.Enabled = false;
            btReplaceAll.Enabled = false;
            tbReplace.Enabled = false;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btFindNext_Click(object sender, EventArgs e)
        {
            if (tbFind.Text == "")
            {
                MessageBox.Show("Please enter a search term.", "FCTB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FindNext(tbFind.Text);
            }
        }

        public virtual void FindNext(string pattern)
        {
            try
            {
                RegexOptions opt = cbMatchCase.Checked ? RegexOptions.None : RegexOptions.IgnoreCase;
                if (!cbRegex.Checked)
                    pattern = Regex.Escape(pattern);
                if (cbWholeWord.Checked)
                    pattern = "\\b" + pattern + "\\b";
                //
                Range range = tb.Selection.Clone();
                range.Normalize();
                //
                if (firstSearch)
                {
                    startPlace = range.Start;
                    firstSearch = false;
                }
                //
                range.Start = range.End;
                if (range.Start >= startPlace)
                    range.End = new Place(tb.GetLineLength(tb.LinesCount - 1), tb.LinesCount - 1);
                else
                    range.End = startPlace;
                //
                foreach (var r in range.GetRangesByLines(pattern, opt))
                {
                    tb.Selection = r;
                    tb.DoSelectionVisible();
                    tb.Invalidate();
                    tsStatusUpdateLabel.Text = "Find: Found search term '" + tbFind.Text + "'.";
                    return;
                }

                //
                if (range.Start >= startPlace && startPlace > Place.Empty)
                {
                    tb.Selection.Start = new Place(0, 0);
                    FindNext(pattern);
                    return;
                }

                tsStatusUpdateLabel.Text = "Find: Unable to find search term '" + tbFind.Text + "'.";
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex);
            }
        }

        private void AdvancedFindAndReplaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
            this.tb.Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override void OnActivated(EventArgs e)
        {
            tbFind.Focus();
            ResetSerach();
        }

        void ResetSerach()
        {
            firstSearch = true;
        }

        private void cbMatchCase_CheckedChanged(object sender, EventArgs e)
        {
            ResetSerach();
        }

        private void cbReplace_CheckedChanged(object sender, EventArgs e)
        {
            if (cbReplace.Checked == true)
            {
                btReplace.Enabled = true;
                btReplaceAll.Enabled = true;
                tbReplace.Enabled = true;
            }
            else
            {
                btReplace.Enabled = false;
                btReplaceAll.Enabled = false;
                tbReplace.Enabled = false;
            }
        }

        private void btReplace_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb.SelectionLength != 0)
                    if (!tb.Selection.ReadOnly)
                        tb.InsertText(tbReplace.Text);
                btFindNext_Click(sender, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btReplaceAll_Click(object sender, EventArgs e)
        {
            try
            {
                tb.Selection.BeginUpdate();

                //search
                var ranges = FindAll(tbFind.Text);
                //check readonly
                var ro = false;
                foreach (var r in ranges)
                    if (r.ReadOnly)
                    {
                        ro = true;
                        break;
                    }
                //replace
                if (!ro)
                    if (ranges.Count > 0)
                    {
                        tb.TextSource.Manager.ExecuteCommand(new ReplaceTextCommand(tb.TextSource, ranges, tbReplace.Text));
                        tb.Selection.Start = new Place(0, 0);
                    }
                //
                tb.Invalidate();

                tsStatusUpdateLabel.Text = ranges.Count + " occurence(s) replaced.";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            tb.Selection.EndUpdate();
        }

        public List<Range> FindAll(string pattern)
        {
            var opt = cbMatchCase.Checked ? RegexOptions.None : RegexOptions.IgnoreCase;
            if (!cbRegex.Checked)
                pattern = Regex.Escape(pattern);
            if (cbWholeWord.Checked)
                pattern = "\\b" + pattern + "\\b";
            //
            var range = tb.Selection.IsEmpty ? tb.Range.Clone() : tb.Selection.Clone();
            //
            var list = new List<Range>();
            foreach (var r in range.GetRangesByLines(pattern, opt))
                list.Add(r);

            return list;
        }

        private void btSwitchFindAndReplace_Click(object sender, EventArgs e)
        {
            string oldFind = tbFind.Text;
            string oldReplace = tbReplace.Text;

            tbFind.Text = oldReplace;
            tbReplace.Text = oldFind;
        }

        private void btFindInFiles_Click(object sender, EventArgs e)
        {

        }
    }
}
