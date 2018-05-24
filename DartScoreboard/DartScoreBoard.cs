using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace Dartboard
{
    public partial class DartBoardMainFrame : Form
    {
        public DartBoardMainFrame()
        {
            InitializeComponent();
        }

        private int pl1Missed;
        private int pl2Missed;
        private int player = 1;
        private double mode = 0;

        private void Reset_Click(object sender, EventArgs e)
        {
            rlyReset();

        }

        private void rlyReset()
        {
            if (MessageBox.Show("Soll das Spiel wirklich zurückgesetzt werden?",
                  "Wirklich?", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pl1.Focus(); 
                resetGame();
            }
            else
                return;
        }

        private void resetGame()
        {
            pl1.Items.Clear();
            pl2.Items.Clear();
            pl13DartScore.Items.Clear();
            pl23DartScore.Items.Clear();
            switch (checkedListBox1.SelectedIndex)
            {
                case 0:
                    pl1.Items.Add("901");
                    pl2.Items.Add("901");
                    mode = 901;
                    break;
                case 1:
                    pl1.Items.Add("501");
                    pl2.Items.Add("501");
                    mode = 501;
                    break;
                case 2:
                    pl1.Items.Add("301");
                    pl2.Items.Add("301");
                    mode = 301;
                    break;
                default:
                    MessageBox.Show("Select Game Mode");
                    break;
            }
            pl1Missed = 0;
            pl2Missed = 0;
        }


        private void pl1Score_Enter(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode != Keys.Enter)
                return;
            addScorePl1(false);
        }

        private void addScorePl1(bool voice)
        {
            int newScore = 0;
            int oldScore = int.Parse(pl1.Items[pl1.Items.Count - 1].ToString());

            if (!int.TryParse(pl1Score.Text, out newScore))
            {
                if (!voice)
                    MessageBox.Show("Ungültiger Score");
                return;
            }
            int rest = oldScore - newScore;
            pl13DartScore.Items.Remove(" ");
            pl13DartScore.Items.Add(newScore.ToString() + "- ");
            pl13DartScore.Items.Add(" ");
            if (rest == 0)
            {
                int darts = (pl1Missed + pl1.Items.Count) * 3;
                MessageBox.Show("Player 1 WON with a " + darts + " Dart Finish \n3 Dart Average: "+ (double)(mode/(darts/3)));
                resetGame();
                return;
            }
            if (rest > 0)
            {
                pl1.Items.Add((rest).ToString());
            }
            if (rest < 0)
            {
                pl1.Items.Add((oldScore).ToString());
                MessageBox.Show("Player 1 NOSCORE");
            }

            pl1Score.Text = ""; 
            pl1.SelectedIndex = pl1.Items.Count - 1;
            if (pl13DartScore.Items.Count>0)
                pl13DartScore.SelectedIndex = pl13DartScore.Items.Count - 1;
        }

        private void pl1Undo_Click(object sender, EventArgs e)
        {
            pl1UndoLastTurn();

        }

        private void pl1UndoLastTurn()
        {
            if (pl1.Items.Count > 1)
            {
                pl1.Items.RemoveAt(pl1.Items.Count - 1);
                pl13DartScore.Items.Remove(" ");
                pl13DartScore.Items.RemoveAt(pl13DartScore.Items.Count - 1);
                pl1.SelectedIndex = pl1.Items.Count - 1;
                if (pl13DartScore.Items.Count > 0)
                    pl13DartScore.SelectedIndex = pl13DartScore.Items.Count - 1;
            }
        }


        private void pl2_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode != Keys.Enter)
                return;
            addScorePl2(false);
        }

        private void addScorePl2(bool voice)
        {
            int newScore = 0;
            int oldScore = int.Parse(pl2.Items[pl2.Items.Count - 1].ToString());

            if (!int.TryParse(pl2Score.Text, out newScore))
            {
                if(!voice)
                    MessageBox.Show("Ungültiger Score");
                return;
            }
            int rest = oldScore - newScore;
            pl23DartScore.Items.Remove(" ");
            pl23DartScore.Items.Add(newScore.ToString()+"- ");
            pl23DartScore.Items.Add(" ");
            if (rest == 0)
            {
                int darts = (pl2Missed + pl2.Items.Count) * 3;
                MessageBox.Show("Player 2 WON with a " + darts + " Dart Finish\n3 Dart Average: "+ (double)(mode/(darts/3)));
                resetGame();
                return;
            }
            if (rest > 0)
            {
                pl2.Items.Add((rest).ToString());
            }
            if (rest < 0)
            {
                pl2.Items.Add((oldScore).ToString());
                MessageBox.Show("Player 2 NOSCORE");
            }

            pl2Score.Text = "";
            pl2.SelectedIndex = pl2.Items.Count - 1;
            if (pl23DartScore.Items.Count > 0)
                pl23DartScore.SelectedIndex = pl23DartScore.Items.Count - 1;
        }

        private void pl2Undo_Click(object sender, EventArgs e)
        {
            pl2UndoLastTurn();
        }

        private void pl2UndoLastTurn()
        {
            if (pl2.Items.Count > 1)
            {
                pl2.Items.RemoveAt(pl2.Items.Count - 1);
                pl23DartScore.Items.Remove(" ");
                pl23DartScore.Items.RemoveAt(pl23DartScore.Items.Count - 1);
                pl2.SelectedIndex = pl2.Items.Count - 1;
                if (pl23DartScore.Items.Count > 0)
                    pl23DartScore.SelectedIndex = pl23DartScore.Items.Count - 1;
            }
        }

        private void pl1NoScore_Click(object sender, EventArgs e)
        {
            pl1Missed++;
        }

        private void pl2NoScore_Click(object sender, EventArgs e)
        {
            pl2Missed++;
        }

     

        void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void activatePl2()
        {
            pl1p1.BackColor = Color.Transparent;
            pl1p2.BackColor = Color.Transparent;
            pl2p1.BackColor = Color.ForestGreen;
            pl2p2.BackColor = Color.ForestGreen;
            player = 2;
        }

        private void activatePl1()
        {
            pl1p1.BackColor = Color.ForestGreen;
            pl1p2.BackColor = Color.ForestGreen;
            pl2p1.BackColor = Color.Transparent;
            pl2p2.BackColor = Color.Transparent;
            player = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SpeechRecognitionEngine _recognizer = null;
            _recognizer = new SpeechRecognitionEngine();
            GrammarBuilder grammarBuilder = new GrammarBuilder();

            Choices befehle = new Choices();
            //befehle.Add(new string[]  { "0","1","2","3","4","5","6","7","8","9","Undo"});
            
            List<string> bef = new List<string>();
            for(int i = 0; i <= 180; i++){
                bef.Add(i.ToString());
            }
            bef.Add("undo");
            bef.Add("Spieler 1");
            bef.Add("Spieler 2");
            bef.Add("Player 1");
            bef.Add("Player 2");
            bef.Add("p1");
            bef.Add("p2");
            bef.Add("reset");
            bef.Add("zurücksetzen");
            befehle.Add(bef.ToArray<string>());
            grammarBuilder.Append(befehle);

            _recognizer.LoadGrammar(new Grammar(grammarBuilder));
            // Create the Grammar instance.
            _recognizer.SetInputToDefaultAudioDevice(); // set input to default audio device
            _recognizer.RecognizeAsync(RecognizeMode.Multiple);

            /*recognizer.LoadGrammar(g);

            recognizer.SpeechRecognized +=new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);*/
            _recognizer.SpeechRecognized += speechRecognitionWithChoices_SpeechRecognized;
            checkedListBox1.SelectedIndex = 1;
            checkedListBox1.SetItemChecked(1, true);
            resetGame();
        }

        private void speechRecognitionWithChoices_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //MessageBox.Show("Speech recognized: " + e.Result.Text);
            switch (e.Result.Text)
            {
                case "undo":
                    if (player == 1)
                        pl1UndoLastTurn();
                    else
                        pl2UndoLastTurn();
                    break;
                case "zurücksetzen":
                    rlyReset();
                    break;
                case "p1":
                    activatePl1();
                    break;
                case "Spieler 1":
                    activatePl1();
                    break;
                case "Player 1":
                    activatePl1();
                    break;
                case "p2":
                case "Spieler 2":
                case "Spieler zwei":
                case "Player 2":
                    activatePl2();
                    break;
                default:
                    int test = 0;
                    if (!int.TryParse(e.Result.Text, out test))
                        return;

                    if (player == 1)
                    {
                        pl1Score.Text = test.ToString();
                        addScorePl1(true);
                        pl1Score.Text = "";
                    }
                    else
                    {
                        pl2Score.Text = test.ToString();
                        addScorePl2(true);
                        pl2Score.Text = "";
                    }
                    break;
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                for (int ix = 0; ix < checkedListBox1.Items.Count; ++ix)
                    if (e.Index != ix) checkedListBox1.SetItemChecked(ix, false);
        }

        private void pl1Score_Enter(object sender, EventArgs e)
        {
            activatePl1();
        }

        private void pl2Score_Enter(object sender, EventArgs e)
        {
            activatePl2();
        }

    }
}
