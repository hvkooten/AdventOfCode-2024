using System;
using System.Windows.Forms;

namespace WordSearchApp
{
    public partial class WordSearchForm : Form
    {
        public WordSearchForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            string word = wordInput.Text;
            string text = textInput.Text;
            WordSearchLogic logic = new WordSearchLogic(text);
            WordSearchLogic logic2 = new WordSearchLogic2(text);
            var (verticalCount, horizontalCount, diagonalCount, totalCount) = logic.SearchWord(word);
            var xmasPatternCount = logic2.SearchWord(word);
            verticalOutput.Text = verticalCount.ToString();
            horizontalOutput.Text = horizontalCount.ToString();
            diagonalOutput.Text = diagonalCount.ToString();
            xmasPatternOutput.Text = xmasPatternCount.ToString();
            totalOutput.Text = totalCount.ToString();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
