using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace QuizGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //variables
        int numberOfQuestion = 1;
        int score = 0;
        int totalQuestion = 30;
        int numberOfQuestionInRound = 10;
        int correctAnswer;              //a flag to save correct answer (1 or 2) of the question for checking with tag in button

        public Random _rng = new Random();
        int number;     //random a new question number

        //array to check that there is no repeat of 1 number of question in 1 round
        int[] checkArray = new int[31];

        //if more than 30s that you dont have the answer, the program will pick the next question and you dont have any score
        private DispatcherTimer _timer;
        int time = 4;

        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < 31; i++)
            {
                checkArray[i] = 0;
            }

            showQuestion(1);
            checkArray[1] = 1;

            numLabel.Content = numberOfQuestion;
            numberOfQuestion++;
            scoreLabel.Content = score;
        }


        private void CheckAnswerEvent(object sender, RoutedEventArgs e)
        {
            var senderOjb = (Button)sender;
            int buttonTag = Convert.ToInt32(senderOjb.Tag);  //save button Tag (when user click to the button)

            do
            {
                number = _rng.Next(1, totalQuestion);
            }
            while (checkArray[number] == 1);
            checkArray[number] = 1;

            //if you have a correct answer, you have 1 point
            if (buttonTag == correctAnswer)
            {
                score++;
            }

            _timer.Stop();

            //1 round only have 10 question
            if (numberOfQuestion > numberOfQuestionInRound)
            {
                scoreLabel.Content = score;
                EndGame();
                return;
            }

            //display number of question and score at that time
            numLabel.Content = numberOfQuestion;
            scoreLabel.Content = score;

            //show question
            showQuestion(number);
            numberOfQuestion++;
        }

        private void EndGame()
        {
            string res = "Số điểm của bạn là: " +score;
            MessageBox.Show(res);
        }

        private void CountDown()
        {
            time = 4;
            _timer = new DispatcherTimer();
            _timer.Interval = new TimeSpan(0, 0, 1);
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time--;
                timerLabel.Content = time;
            }
            else
            {
                _timer.Stop();

                do
                {
                    number = _rng.Next(1, totalQuestion);
                }
                while (checkArray[number] == 1);
                checkArray[number] = 1;

                if (numberOfQuestion > numberOfQuestionInRound)         //case: the last question and time out
                {
                    EndGame();
                    return;
                }

                numLabel.Content = numberOfQuestion;
                scoreLabel.Content = score;

                showQuestion(number);
                numberOfQuestion++;
            }
        }


        //function use to display image for each question
        private void displayImage(string imgName)
        {
            var bitmap = new BitmapImage(
                        new Uri($"images/{imgName}",
                        UriKind.Relative)
                        );
            QImage.Source = bitmap;
        }

        private void showQuestion(int num)
        {
            CountDown();

            string imgName;

            //30 question in here
            switch (num)
            {
                case 1:
                    imgName = "1.jpg";
                    displayImage(imgName);

                    Button1.Content = "J. K. Rowling";
                    Button2.Content = "Victor Hugo";

                    QTextBlock.Text = "Ai là tác giả của bộ truyện giả tưởng nổi tiếng thế giới Harry Potter?";
                    correctAnswer = 1;
                    break;

                case 2:
                    imgName = "2.jpg";
                    displayImage(imgName);

                    Button1.Content = "Harry Potter";
                    Button2.Content = "Draco Malfoy";

                    QTextBlock.Text = "Đâu là tên nhân vật này trong truyện Harry Potter?";
                    correctAnswer = 2;
                    break;

                case 3:
                    imgName = "3.jpg";
                    displayImage(imgName);

                    Button1.Content = "Cedric Diggory";
                    Button2.Content = "Fred Weasley";


                    QTextBlock.Text = "Đâu là tên nhân vật này trong truyện Harry Potter?";
                    correctAnswer = 1;
                    break;

                case 4:
                    imgName = "4.jpg";
                    displayImage(imgName);

                    Button1.Content = "993";
                    Button2.Content = "994";

                    QTextBlock.Text = "Lâu đài Hogwarts được thành lập vào khoảng năm nào?";
                    correctAnswer = 1;
                    break;

                case 5:
                    imgName = "5.jpg";
                    displayImage(imgName);

                    Button1.Content = "Tu sĩ béo";
                    Button2.Content = "Bà béo";

                    QTextBlock.Text = "Ai bảo vệ lối vào phòng sinh hoạt chung nhà Gryffindor?";
                    correctAnswer = 2;
                    break;

                case 6:
                    imgName = "6.jpg";
                    displayImage(imgName);

                    Button1.Content = "Mắt điên";
                    Button2.Content = "Cornelius Fudge";

                    QTextBlock.Text = "Ai KHÔNG phải là thành viên của Hội Phượng hoàng?";
                    correctAnswer = 2;
                    break;

                case 7:
                    imgName = "7.jpg";
                    displayImage(imgName);

                    Button1.Content = "Một chiếc áo len mới";
                    Button2.Content = "Ếch sô cô la";

                    QTextBlock.Text = "Bà Weasley tặng Harry gì cho Giáng sinh hàng năm?";
                    correctAnswer = 1;
                    break;

                case 8:
                    imgName = "8.jpg";
                    displayImage(imgName);

                    Button1.Content = "Giải đấu Quidditch";
                    Button2.Content = "Giải đấu Triwizard";

                    QTextBlock.Text = "Tên giải đấu mà phần thưởng là chiếc cúp này?";
                    correctAnswer = 2;
                    break;

                case 9:
                    imgName = "9.jpg";
                    displayImage(imgName);

                    Button1.Content = "Jeremy Irons";
                    Button2.Content = "Ralph Fiennes";

                    QTextBlock.Text = "Ai đã đóng vai Chúa tể Voldemort trong các bộ phim?";
                    correctAnswer = 2;
                    break;

                case 10:
                    imgName = "10.jpg";
                    displayImage(imgName);

                    Button1.Content = "Bùa Bay";
                    Button2.Content = "Bùa Nhảy";

                    QTextBlock.Text = "Đây là loại bùa gì?";
                    correctAnswer = 1;
                    break;

                case 11:
                    imgName = "11.jpg";
                    displayImage(imgName);

                    Button1.Content = "Phòng tắm rên rỉ Myrtle";
                    Button2.Content = "Nhà bếp Hogwarts";

                    QTextBlock.Text = "Hermione ủ lô Polyjuice Potion đầu tiên ở đâu?";
                    correctAnswer = 1;
                    break;

                case 12:
                    imgName = "12.jpg";
                    displayImage(imgName);

                    Button1.Content = "Tại Bộ Pháp thuật";
                    Button2.Content = "Trong rừng cấm";

                    QTextBlock.Text = "Harry và Ron cuối cùng tìm thấy chiếc Ford Anglia đang mất tích ở đâu?";
                    correctAnswer = 2;
                    break;

                case 13:
                    imgName = "13.jpg";
                    displayImage(imgName);

                    Button1.Content = "Giáo sư Grubbly-Plank";
                    Button2.Content = "Bà Hooch";

                    QTextBlock.Text = "Giáo sư nào dạy bài học bay?";
                    correctAnswer = 2;
                    break;

                case 14:
                    imgName = "14.jpg";
                    displayImage(imgName);

                    Button1.Content = "Chín và ba phần tư";
                    Button2.Content = "Tám và một phần tư";

                    QTextBlock.Text = "Từ nền tảng của King Cross, Hogwarts Express rời đi từ đâu?";
                    correctAnswer = 1;
                    break;

                case 15:
                    imgName = "15.jpg";
                    displayImage(imgName);

                    Button1.Content = "Bà Norris";
                    Button2.Content = "Ser Pounce";

                    QTextBlock.Text = "Tên của con mèo Filch là gì?";
                    correctAnswer = 1;
                    break;

                case 16:
                    imgName = "16.jpg";
                    displayImage(imgName);

                    Button1.Content = "Huggs và Pucey";
                    Button2.Content = "Crabbe và Goyle";

                    QTextBlock.Text = "Tên của hai người bạn thân của Draco Malfoy là gì?";
                    correctAnswer = 2;
                    break;

                case 17:
                    imgName = "17.jpg";
                    displayImage(imgName);

                    Button1.Content = "Patronia P Parentus";
                    Button2.Content = "Expecto Patronum";

                    QTextBlock.Text = "Làm thế nào để bạn triệu tập một Patronus?";
                    correctAnswer = 2;
                    break;

                case 18:
                    imgName = "18.jpg";
                    displayImage(imgName);

                    Button1.Content = "Hedwig";
                    Button2.Content = "Pigwidgeon";

                    QTextBlock.Text = "Tên của con cú Harry Potter là gì?";
                    correctAnswer = 1;
                    break;

                case 19:
                    imgName = "19.jpg";
                    displayImage(imgName);

                    Button1.Content = "Rupert Grint";
                    Button2.Content = "Daniel Radcliffe";

                    QTextBlock.Text = "Ai đã đóng vai Harry Potter?";
                    correctAnswer = 2;
                    break;

                case 20:
                    imgName = "20.jpg";
                    displayImage(imgName);

                    Button1.Content = "Godric Gryffindor";
                    Button2.Content = "Salazar Slytherin";

                    QTextBlock.Text = "Ai là chủ sở hữu ban đầu của Mũ phân loại?";
                    correctAnswer = 1;
                    break;

                case 21:
                    imgName = "21.jpg";
                    displayImage(imgName);

                    Button1.Content = "Snape Severus";
                    Button2.Content = "Jame Potter";

                    QTextBlock.Text = "Ai tiết lộ với Lily Potter rằng cô là phù thủy?";
                    correctAnswer = 1;
                    break;

                case 22:
                    imgName = "22.jpg";
                    displayImage(imgName);

                    Button1.Content = "Rowena Ravenclaw";
                    Button2.Content = "Salazar Slytherin";

                    QTextBlock.Text = "Thành viên sáng lập nào của Hogwarts lập luận rằng trường chỉ nên phục vụ cho những người thuần chủng?";
                    correctAnswer = 2;
                    break;

                case 23:
                    imgName = "23.jpg";
                    displayImage(imgName);

                    Button1.Content = "Nhà tiên tri hàng tuần";
                    Button2.Content = "Nhà tiên tri hàng ngày";

                    QTextBlock.Text = "Tên của tờ báo phù thủy có trụ sở tại London là gì?";
                    correctAnswer = 2;
                    break;

                case 24:
                    imgName = "24.jpg";
                    displayImage(imgName);

                    Button1.Content = "Gryffindor";
                    Button2.Content = "Slytherin";

                    QTextBlock.Text = "Giáo sư Albus Dumbledore thuộc nhà nào?";
                    correctAnswer = 1;
                    break;

                case 25:
                    imgName = "25.jpg";
                    displayImage(imgName);

                    Button1.Content = "Cây ô rô";
                    Button2.Content = "Cây phượng";

                    QTextBlock.Text = "Cây đũa phép của Harry Potter được làm từ gỗ gì?";
                    correctAnswer = 1;
                    break;

                case 26:
                    imgName = "26.jpg";
                    displayImage(imgName);

                    Button1.Content = "Máu lai";
                    Button2.Content = "Người lai";

                    QTextBlock.Text = "Thuật ngữ nào đề cập đến phù thủy và phù thủy có cả ma thuật và tổ tiên Muggle?";
                    correctAnswer = 1;
                    break;

                case 27:
                    imgName = "27.jpg";
                    displayImage(imgName);

                    Button1.Content = "Trường sinh linh giá";
                    Button2.Content = "Bảo bối tử thần";

                    QTextBlock.Text = "Tên tập thể của ba vật thể ma thuật mà khi được sở hữu bởi một người được cho là làm chủ cái chết?";
                    correctAnswer = 2;
                    break;

                case 28:
                    imgName = "28.jpg";
                    displayImage(imgName);

                    Button1.Content = "Hippogriff";
                    Button2.Content = "Buckbeak";

                    QTextBlock.Text = "Thú cưng của Hagrid đã bị kết án tử hình vì làm Draco Malfoy bị thương. Tên của thú cưng là gì?";
                    correctAnswer = 2;
                    break;

                case 29:
                    imgName = "29.jpg";
                    displayImage(imgName);

                    Button1.Content = "Cho Chang";
                    Button2.Content = "Luna Lovegood";

                    QTextBlock.Text = "Tên nhân vật này trong bộ truyệ Harry Potter.";
                    correctAnswer = 2;
                    break;

                case 30:
                    imgName = "30.jpg";
                    displayImage(imgName);

                    Button1.Content = "Nimbus 2000";
                    Button2.Content = "Hoover";

                    QTextBlock.Text = "Mô hình của cây chổi đầu tiên Harry từng nhận được là gì?";
                    correctAnswer = 1;
                    break;
            }
        }
    }
}
