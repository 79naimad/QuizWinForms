using QuizBS.Common.Model;
using QuizBS.DataAccess;
using QuizBS.ViewModel;

namespace QuizBS
{
    public partial class MainView : Form
    {
        #region Fields

        private MainViewModel _viewModel;

        #endregion

        #region Constructors

        public MainView()
        {

            _viewModel = new MainViewModel(new QuizBSDataProvider());
            InitializeComponent();
        }

        #endregion

        #region Logic

        private void MainView_Load(object sender, EventArgs e)
        {

            _viewModel.Load();
            questionBindingForms.DataSource = _viewModel.Questions;

            lblQuestion.DataBindings.Add("Text", questionBindingForms, "Text", false, DataSourceUpdateMode.OnPropertyChanged);
            lblId.DataBindings.Add("Text", questionBindingForms, "Id", false, DataSourceUpdateMode.OnPropertyChanged);

            cBoxA.DataBindings.Add("Text", questionBindingForms, "AnswerA", false, DataSourceUpdateMode.OnPropertyChanged);
            cBoxB.DataBindings.Add("Text", questionBindingForms, "AnswerB", false, DataSourceUpdateMode.OnPropertyChanged);
            cBoxC.DataBindings.Add("Text", questionBindingForms, "AnswerC", false, DataSourceUpdateMode.OnPropertyChanged);
            cBoxD.DataBindings.Add("Text", questionBindingForms, "AnswerD", false, DataSourceUpdateMode.OnPropertyChanged);
            cBoxA.DataBindings.Add("Checked", questionBindingForms, "A", false, DataSourceUpdateMode.OnPropertyChanged);
            cBoxB.DataBindings.Add("Checked", questionBindingForms, "B", false, DataSourceUpdateMode.OnPropertyChanged);
            cBoxC.DataBindings.Add("Checked", questionBindingForms, "C", false, DataSourceUpdateMode.OnPropertyChanged);
            cBoxD.DataBindings.Add("Checked", questionBindingForms, "D", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        #region Events

        private void btnPrievQuestion_Click(object sender, EventArgs e)
        {

            questionBindingForms.MovePrevious();
            btnFinish.Visible = false;
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {

            questionBindingForms.MoveNext();
            if (questionBindingForms.Current == _viewModel.Questions[questionBindingForms.Count - 1])
            {
                btnFinish.Visible = true;
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {

            _viewModel.CheckingAnswers();
            DialogResult res = MessageBox.Show("Twój wynik: " + Question.Result.ToString() + " / " + _viewModel.Questions.Last().Id, "Result", MessageBoxButtons.RetryCancel);
            if(res == DialogResult.Cancel)
            {
                Application.Exit();
            }
            else
            {
                questionBindingForms.MoveFirst();
                btnFinish.Visible = false;
                Question.Result = 0;
                QuizBSDataProvider temp = new QuizBSDataProvider();
                temp.LoadQuestions();
                _viewModel = new MainViewModel(temp);
                _viewModel.Load();
                questionBindingForms.DataSource = _viewModel.Questions;
            }

        #endregion

        #endregion
        }

    }
}