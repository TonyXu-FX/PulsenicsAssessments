using PulsenicsAssessments.Forms;

namespace PulsenicsAssessments
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ToFileSearch_Click(object sender, EventArgs e)
        {
            var fileSearch = new FileSearch();
            fileSearch.Show();
        }

        private void ToAddUpdateUsers_Click(object sender, EventArgs e)
        {
            var addUser = new AddUser();
            addUser.Show();
        }

        private void ToAssignFiles_Click(object sender, EventArgs e)
        {
            var assignFile = new AssignFile();
            assignFile.Show();
        }

        private void ToUserSearch_Click(object sender, EventArgs e)
        {
            var userSearch = new UserSearch();
            userSearch.Show();
        }
    }
}