using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MSSABlackJack
{
    public partial class Form1 : Form
    {

        // To Do: If the wrong answer is given by the user, show what the correct move would have been.
        // When player splits hand, actually split hand and allow to play out
        // Track what player gets wrong and right

        #region Creating lists and whatnot

        // Creating PlayerCardList
        private readonly List<Card> PlayerCardList = new List<Card> {
            new Card {
                Value = 0,
                Name = "null",
                Image = "null"
            }
        };

        // Creating DealerCardList
        private readonly List<Card> DealerCardList = new List<Card> {
            new Card {
                Value = 0,
                Name = "null",
                Image = "null"
            }
        };

        private int PlayerHandSum;
        private int DealerHandSum;
        public bool CorrectMove = false;


        private readonly Random random = new Random();

        private readonly List<Card> UsedCardDeck = new List<Card> {
            new Card {
                Value = 0,
                Name = "null",
                Image = "null"
            }
        };

        private readonly List<int> UsedCards = new List<int>();

        #endregion

        // Creating deck
        #region CardDeck

        private readonly List<Card> CardDeck = new List<Card> {
            new Card {
                Value = 2,
                Name = "Two of Spades",
                Image = "2_S.png"
            },
            new Card {
                Value = 3,
                Name = "Three of Spades",
                Image = "3_S.png"
            },
            new Card {
                Value = 4,
                Name = "Four of Spades",
                Image = "4_S.png"
            },
            new Card {
                Value = 5,
                Name = "Five of Spades",
                Image = "5_S.png"
            },
            new Card {
                Value = 6,
                Name = "Six of Spades",
                Image = "6_S.png"
            },
            new Card {
                Value = 7,
                Name = "Seven of Spades",
                Image = "7_S.png"
            },
            new Card {
                Value = 8,
                Name = "Eight of Spades",
                Image = "8_S.png"
            },
            new Card {
                Value = 9,
                Name = "Nine of Spades",
                Image = "9_S.png"
            },
            new Card {
                Value = 10,
                Name = "Ten of Spades",
                Image = "10_S.png"
            },
            new Card {
                Value = 10,
                Name = "Jack of Spades",
                Image = "J_S.png"
            },
            new Card {
                Value = 10,
                Name = "Queen of Spades",
                Image = "Q_S.png"
            },
            new Card {
                Value = 10,
                Name = "King of Spades",
                Image = "K_S.png"
            },
            new Card {
                Value = 11,
                Name = "Ace of Spades",
                Image = "A_S.png"
            },
            new Card {
                Value = 2,
                Name = "Two of Diamonds",
                Image = "2_D.png"
            },
            new Card {
                Value = 3,
                Name = "Three of Diamonds",
                Image = "3_D.png"
            },
            new Card {
                Value = 4,
                Name = "Four of Diamonds",
                Image = "4_D.png"
            },
            new Card {
                Value = 5,
                Name = "Five of Diamonds",
                Image = "5_D.png"
            },
            new Card {
                Value = 6,
                Name = "Six of Diamonds",
                Image = "6_D.png"
            },
            new Card {
                Value = 7,
                Name = "Seven of Diamonds",
                Image = "7_D.png"
            },
            new Card {
                Value = 8,
                Name = "Eight of Diamonds",
                Image = "8_D.png"
            },
            new Card {
                Value = 9,
                Name = "Nine of Diamonds",
                Image = "9_D.png"
            },
            new Card {
                Value = 10,
                Name = "Ten of Diamonds",
                Image = "10_D.png"
            },
            new Card {
                Value = 10,
                Name = "Jack of Diamonds",
                Image = "J_D.png"
            },
            new Card {
                Value = 10,
                Name = "Queen of Diamonds",
                Image = "Q_D.png"
            },
            new Card {
                Value = 10,
                Name = "King of Diamonds",
                Image = "K_D.png"
            },
            new Card {
                Value = 11,
                Name = "Ace of Diamonds",
                Image = "A_D.png"
            },
            new Card {
                Value = 2,
                Name = "Two of Clubs",
                Image = "2_C.png"
            },
            new Card {
                Value = 3,
                Name = "Three of Clubs",
                Image = "3_C.png"
            },
            new Card {
                Value = 4,
                Name = "Four of Clubs",
                Image = "4_C.png"
            },
            new Card {
                Value = 5,
                Name = "Five of Clubs",
                Image = "5_C.png"
            },
            new Card {
                Value = 6,
                Name = "Six of Clubs",
                Image = "6_C.png"
            },
            new Card {
                Value = 7,
                Name = "Seven of Clubs",
                Image = "7_C.png"
            },
            new Card {
                Value = 8,
                Name = "Eight of Clubs",
                Image = "8_C.png"
            },
            new Card {
                Value = 9,
                Name = "Nine of Clubs",
                Image = "9_C.png"
            },
            new Card {
                Value = 10,
                Name = "Ten of Clubs",
                Image = "10_C.png"
            },
            new Card {
                Value = 10,
                Name = "Jack of Clubs",
                Image = "J_C.png"
            },
            new Card {
                Value = 10,
                Name = "Queen of Clubs",
                Image = "Q_C.png"
            },
            new Card {
                Value = 10,
                Name = "King of Clubs",
                Image = "K_C.png"
            },
            new Card {
                Value = 11,
                Name = "Ace of Clubs",
                Image = "A_C.png"
            },
            new Card {
                Value = 2,
                Name = "Two of Hearts",
                Image = "2_H.png"
            },
            new Card {
                Value = 3,
                Name = "Three of Hearts",
                Image = "3_H.png"
            },
            new Card {
                Value = 4,
                Name = "Four of Hearts",
                Image = "4_H.png"
            },
            new Card {
                Value = 5,
                Name = "Five of Hearts",
                Image = "5_H.png"
            },
            new Card {
                Value = 6,
                Name = "Six of Hearts",
                Image = "6_H.png"
            },
            new Card {
                Value = 7,
                Name = "Seven of Hearts",
                Image = "7_H.png"
            },
            new Card {
                Value = 8,
                Name = "Eight of Hearts",
                Image = "8_H.png"
            },
            new Card {
                Value = 9,
                Name = "Nine of Hearts",
                Image = "9_H.png"
            },
            new Card {
                Value = 10,
                Name = "Ten of Hearts",
                Image = "10_H.png"
            },
            new Card {
                Value = 10,
                Name = "Jack of Hearts",
                Image = "J_H.png"
            },
            new Card {
                Value = 10,
                Name = "Queen of Hearts",
                Image = "Q_H.png"
            },
            new Card {
                Value = 10,
                Name = "King of Hearts",
                Image = "K_H.png"
            },
            new Card {
                Value = 11,
                Name = "Ace of Hearts",
                Image = "A_H.png"
            }
        };

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        internal void Form1_Load(object sender, EventArgs e)
        {
            ResetGame();
            DisableButtons();
        }

        internal void StartButton_Click(object sender, EventArgs e)
        {

            CorrectMove = false;
            EnableButtons();
            SplitButton.Enabled = true;
            PlayerCard3.Visible = false;
            PlayerCard4.Visible = false;
            PlayerCard5.Visible = false;

            PlayerHandSum = 0;

            UsedCardDeck.AddRange(PlayerCardList);
            PlayerCardList.Clear();

            DealerHandSum = 0;
            UsedCardDeck.AddRange(DealerCardList);
            DealerCardList.Clear();

            // player's hand
            var CardOne = SelectRandomCard();
            var cardOne = CardDeck[CardOne];
            UsedCards.Add(CardOne);
            var CardTwo = SelectRandomCard();
            while (UsedCards.Contains(CardTwo))
                CardTwo = SelectRandomCard();

            var cardTwo = CardDeck[CardTwo];
            UsedCards.Add(CardTwo);

            PlayerCardList.Add(cardOne);
            PlayerCardList.Add(cardTwo);

            PlayerCard1.ImageLocation = cardOne.Image;
            PlayerCard1.SizeMode = PictureBoxSizeMode.StretchImage;

            PlayerCard2.ImageLocation = cardTwo.Image;
            PlayerCard2.SizeMode = PictureBoxSizeMode.StretchImage;

            // dealer's hand
            var CardThree = SelectRandomCard();
            while (UsedCards.Contains(CardThree))
                CardThree = SelectRandomCard();

            var cardThree = CardDeck[CardThree];
            UsedCards.Add(CardThree);

            DealerCardList.Add(cardThree);

            DealerCard1.ImageLocation = cardThree.Image;
            DealerCard1.SizeMode = PictureBoxSizeMode.StretchImage;

            SumPlayerHand(CorrectMove);

            if (PlayerHandSum == 21)
            {
                MessageBox.Show("You win!");
                ResetGame();
            }
            hitMeButton.Enabled = true;
        }

        internal void hitMeButton_Click(object sender, EventArgs e)
        {
            CorrectMove = false;
            SumPlayerHand(CorrectMove);
            SumDealerHand();
            var PlayerHasAces = CheckForAces();

            //hard total
            if (PlayerHasAces == false && PlayerHandSum <= 8)
            {
                AddCardForPlayer();
                CorrectMove = true;
                SumPlayerHand(CorrectMove);
            }
            //hard total
            else if (PlayerHasAces == false && PlayerHandSum == 9 && DealerHandSum == 2 && DealerHandSum < 6)
            {
                AddCardForPlayer();
                CorrectMove = true;
                SumPlayerHand(CorrectMove);
            }
            //hard total
            else if (PlayerHasAces == false && PlayerHandSum == 10 && DealerHandSum > 9)
            {
                AddCardForPlayer();
                CorrectMove = true;
                SumPlayerHand(CorrectMove);

            }
            //hard total
            else if (PlayerHasAces == false && PlayerHandSum > 12 && PlayerHandSum < 17 && DealerHandSum > 6)
            {
                AddCardForPlayer();
                CorrectMove = true;
                SumPlayerHand(CorrectMove);
            }
            //hard total
            else if (PlayerHasAces == false && PlayerHandSum == 12 && DealerHandSum == 2 || DealerHandSum == 3 || DealerHandSum > 6)
            {
                AddCardForPlayer();
                CorrectMove = true;
                SumPlayerHand(CorrectMove);
            }
            //hard total 
            else if (PlayerHasAces == false && PlayerHandSum > 12 && PlayerHandSum < 17 && DealerHandSum > 6)
            {
                AddCardForPlayer();
                CorrectMove = true;
                SumPlayerHand(CorrectMove);
            }
            //soft total
            else if (PlayerHasAces == true && PlayerHandSum == 13 && DealerHandSum < 5 || DealerHandSum > 6)
            {
                AddCardForPlayer();
                CorrectMove = true;
                SumPlayerHand(CorrectMove);
            }
            //soft total
            else if (PlayerHasAces == true && PlayerHandSum == 14 && DealerHandSum < 5 || DealerHandSum > 6)
            {
                AddCardForPlayer();
                CorrectMove = true;
                SumPlayerHand(CorrectMove);
            }
            //soft total
            else if (PlayerHasAces == true && PlayerHandSum == 15 && DealerHandSum == 2 || DealerHandSum == 3 || DealerHandSum > 6)
            {
                AddCardForPlayer();
                CorrectMove = true;
                SumPlayerHand(CorrectMove);
            }
            //soft total
            else if (PlayerHasAces == true && PlayerHandSum == 16 && DealerHandSum == 2 || DealerHandSum == 3 || DealerHandSum > 6)
            {
                AddCardForPlayer();
                CorrectMove = true;
                SumPlayerHand(CorrectMove);
            }
            //soft total
            else if (PlayerHasAces == true && PlayerHandSum == 17 && DealerHandSum == 2 || DealerHandSum > 6)
            {
                AddCardForPlayer();
                CorrectMove = true;
                SumPlayerHand(CorrectMove);
            }

            //soft total
            else if (PlayerHasAces == true && PlayerHandSum == 18 && DealerHandSum > 8)
            {
                AddCardForPlayer();
                CorrectMove = true;
                SumPlayerHand(CorrectMove);
            }
            else
            {
                MessageBox.Show("You have not correctly implemented Basic Strategy\n Try again");
                DisableButtons();
            }
            StartButton.Enabled = true;
        }

        private void SurrenderButton_Click(object sender, EventArgs e)
        {
            CorrectMove = false;
            PlayerHandSum = 0;
            SumPlayerHand(CorrectMove);
            SumDealerHand();
            var PlayerHasAces = CheckForAces();

            //hard total
            if (PlayerHasAces == false && PlayerHandSum == 16 && DealerHandSum > 8)
            {
                DisableButtons();
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            //hard total
            else if (PlayerHasAces == false && PlayerHandSum == 15 && DealerHandSum == 10)
            {
                DisableButtons();
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            else
            {
                DisableButtons();
                MessageBox.Show("You have not correctly implemented Basic Strategy\n Try again");
            }
        }


        private void SplitButton_Click_1(object sender, EventArgs e)
        {
            CorrectMove = false;
            PlayerHandSum = 0;
            SumPlayerHand(CorrectMove);
            SumDealerHand();

            if (PlayerCardList[0] == PlayerCardList[1] && PlayerCardList[0].Value == 11)
            {
                SplitCards();
                DisableButtons();
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            else if (PlayerCardList[0] == PlayerCardList[1] && PlayerCardList[0].Value == 10)
            {
                DisableButtons();
                MessageBox.Show("You have not correctly implemented Basic Strategy\n Try again");
            }
            else if (PlayerCardList[0] == PlayerCardList[1] && PlayerCardList[0].Value == 9 && DealerHandSum > 1 && DealerHandSum < 9 && DealerHandSum != 7)
            {
                SplitCards();
                DisableButtons();
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            else if ((PlayerCardList[0] == PlayerCardList[1] && PlayerCardList[0].Value == 9 && DealerHandSum == 10) || DealerHandSum == 11)
            {
                DisableButtons();
                MessageBox.Show("You have not correctly implemented Basic Strategy\n Try again");
            }
            else if (PlayerCardList[0] == PlayerCardList[1] && PlayerCardList[0].Value == 8)
            {
                SplitCards();
                DisableButtons();
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            else if (PlayerCardList[0] == PlayerCardList[1] && PlayerCardList[0].Value == 7 && DealerHandSum > 1 && DealerHandSum < 8)
            {
                SplitCards();
                DisableButtons();
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            else if (PlayerCardList[0] == PlayerCardList[1] && PlayerCardList[0].Value == 7 && DealerHandSum > 7)
            {
                DisableButtons();
                MessageBox.Show("You have not correctly implemented Basic Strategy\n Try again");
            }
            else if (PlayerCardList[0] == PlayerCardList[1] && PlayerCardList[0].Value == 6 && DealerHandSum > 1 && DealerHandSum < 7)
            {
                SplitCards();
                DisableButtons();
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            else if (PlayerCardList[0] == PlayerCardList[1] && PlayerCardList[0].Value == 6 && DealerHandSum > 6)
            {
                DisableButtons();
                MessageBox.Show("You have not correctly implemented Basic Strategy\n Try again");
            }
            else if (PlayerCardList[0] == PlayerCardList[1] && PlayerCardList[0].Value == 5)
            {
                DisableButtons();
                MessageBox.Show("You have not correctly implemented Basic Strategy\n Try again");
            }
            else if ((PlayerCardList[0] == PlayerCardList[1] && PlayerCardList[0].Value == 4 && DealerHandSum == 5) || DealerHandSum == 6)
            {
                SplitCards();
                DisableButtons();
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            else if ((PlayerCardList[0] == PlayerCardList[1] && PlayerCardList[0].Value == 4 && DealerHandSum != 5) || DealerHandSum != 6)
            {
                DisableButtons();
                MessageBox.Show("You have not correctly implemented Basic Strategy\n Try again");
            }
            else if (PlayerCardList[0] == PlayerCardList[1] && PlayerCardList[0].Value == 3 && DealerHandSum > 1 && DealerHandSum < 8)
            {
                SplitCards();
                DisableButtons();
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            else if (PlayerCardList[0] == PlayerCardList[1] && PlayerCardList[0].Value == 3 && DealerHandSum > 7)
            {
                DisableButtons();
                MessageBox.Show("You have not correctly implemented Basic Strategy\n Try again");
            }
            else if (PlayerCardList[0] == PlayerCardList[1] && PlayerCardList[0].Value == 2 && DealerHandSum > 1 && DealerHandSum < 8)
            {
                SplitCards();
                DisableButtons();
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            else if (PlayerCardList[0] == PlayerCardList[1] && PlayerCardList[0].Value == 2 && DealerHandSum > 7)
            {
                DisableButtons();
                MessageBox.Show("You have not correctly implemented Basic Strategy\n Try again");
            }
            else
            {
                MessageBox.Show("You have not correctly implemented Basic Strategy\n Try again");
            }
        }

        private void DoubleButton_Click_1(object sender, EventArgs e)
        {
            CorrectMove = false;
            PlayerHandSum = 0;
            SumPlayerHand(CorrectMove);
            SumDealerHand();
            var PlayerHasAces = CheckForAces();
            StartButton.Enabled = true;

            //hard total
            if (PlayerHasAces == false && PlayerHandSum == 9 && DealerHandSum > 2 && DealerHandSum < 7)
            {
                AddCardForPlayer();
                DisableButtons();
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            //hard total
            else if (PlayerHasAces == false && PlayerHandSum == 10 && DealerHandSum > 1 && DealerHandSum < 10)
            {
                AddCardForPlayer();
                DisableButtons();
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            //hard total
            else if (PlayerHasAces == false && PlayerHandSum == 11)
            {
                AddCardForPlayer();
                DisableButtons();
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            //soft total
            else if (PlayerHasAces == true && PlayerHandSum == 13 && DealerHandSum == 5 || DealerHandSum == 6)
            {
                AddCardForPlayer();
                DisableButtons();
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            //soft total
            else if (PlayerHasAces == true && PlayerHandSum == 14 && DealerHandSum == 5 || DealerHandSum == 6)
            {
                AddCardForPlayer();
                DisableButtons();
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            //soft total
            else if (PlayerHasAces == true && PlayerHandSum == 15 && DealerHandSum > 3 && DealerHandSum < 7)
            {
                AddCardForPlayer();
                DisableButtons();
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            //soft total
            else if (PlayerHasAces == true && PlayerHandSum == 16 && DealerHandSum > 3 && DealerHandSum < 7)
            {
                AddCardForPlayer();
                DisableButtons();
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            //soft total
            else if (PlayerHasAces == true && PlayerHandSum == 17 && DealerHandSum > 2 && DealerHandSum < 7)
            {
                AddCardForPlayer();
                DisableButtons();
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            //soft total
            else if (PlayerHasAces == true && PlayerHandSum == 18 && DealerHandSum > 1 && DealerHandSum < 7)
            {
                AddCardForPlayer();
                DisableButtons();
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            //soft total
            else if (PlayerHasAces == true && PlayerHandSum == 19 && DealerHandSum == 6)
            {
                AddCardForPlayer();
                DisableButtons();
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            else
            {
                DisableButtons();
                MessageBox.Show("You have not correctly implemented Basic Strategy\n Try again");
            }
        }

        internal void StandButton_Click1(object sender, EventArgs e)
        {
            CorrectMove = false;
            DisableButtons();
            PlayerHandSum = 0;
            SumPlayerHand(CorrectMove);
            SumDealerHand();
            var PlayerHasAces = CheckForAces();

            //hard total
            if (PlayerHasAces == false && PlayerHandSum == 12 && DealerHandSum > 3 && DealerHandSum > 3 && DealerHandSum < 7)
            {
                DisableButtons();
                StartButton.Enabled = true;
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            else if (PlayerHasAces == false && PlayerHandSum == 13 && DealerHandSum > 1 && DealerHandSum < 7)
            {
                DisableButtons();
                StartButton.Enabled = true;
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            //hard total
            else if (PlayerHasAces == false && PlayerHandSum == 14 && DealerHandSum > 1 && DealerHandSum < 7)
            {
                DisableButtons();
                StartButton.Enabled = true;
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            //hard total
            else if (PlayerHasAces == false && PlayerHandSum == 15 && DealerHandSum > 1 && DealerHandSum < 7)
            {
                DisableButtons();
                StartButton.Enabled = true;
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            //hard total
            else if (PlayerHasAces == false && PlayerHandSum == 16 && DealerHandSum > 1 && DealerHandSum < 7)
            {
                DisableButtons();
                StartButton.Enabled = true;
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            //hard total
            else if (PlayerHasAces == false && PlayerHandSum >= 17)
            {
                DisableButtons();
                StartButton.Enabled = true;
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            //soft total
            else if (PlayerHasAces == true && PlayerHandSum == 18 && DealerHandSum == 7 || DealerHandSum == 8)
            {
                DisableButtons();
                StartButton.Enabled = true;
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            //soft total
            else if (PlayerHasAces == true && PlayerHandSum == 19 && DealerHandSum != 6)
            {
                DisableButtons();
                StartButton.Enabled = true;
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            //soft total
            else if (PlayerHasAces == true && PlayerHandSum == 20)
            {
                DisableButtons();
                StartButton.Enabled = true;
                MessageBox.Show("You have correctly implemented Basic Strategy, good job!\n Play again");
            }
            //soft total
            else
            {
                DisableButtons();
                StartButton.Enabled = true;
                MessageBox.Show("You have not correctly implemented Basic Strategy\n Try again");
            }
        }

        internal void resetButton_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        internal void ResetGame()
        {
            DisplayCardBack(PlayerCard1);
            DisplayCardBack(PlayerCard2);
            DisplayCardBack(DealerCard1);

            PlayerHandSum = 0;
            DealerHandSum = 0;
            PlayerCardList.Clear();
            DealerCardList.Clear();
            UsedCards.Clear();
            PlayerCard3.Visible = false;
            PlayerCard4.Visible = false;
            PlayerCard5.Visible = false;
            StartButton.Enabled = true;
        }

        internal void DisplayCardBack(PictureBox picturebox)
        {
            picturebox.ImageLocation = "CardBack.png";
            picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        internal int SelectRandomCard()
        {
            int RandomCard;
            RandomCard = random.Next(0, CardDeck.Count);
            return RandomCard;
        }

        internal void SumPlayerHand(bool correctMove)
        {
            PlayerHandSum = 0;

            for (var i = 0; i < PlayerCardList.Count; i++)
                PlayerHandSum += PlayerCardList[i].Value;

            if (PlayerHandSum > 21)
            {
                foreach (var c in PlayerCardList)
                {
                    if (c.Value == 11)
                    {
                        // Changing Ace to 1 if soft total exceeds 21
                        PlayerHandSum -= 10;
                    }
                }
                if (PlayerHandSum > 21 && CorrectMove == true)
                {
                    MessageBox.Show("Your hand has exceed 21, however you still made the correct move\nTry again");
                }
            }
        }

        internal void SumDealerHand()
        {
            DealerHandSum = 0;
            for (var i = 0; i < DealerCardList.Count; i++)
                DealerHandSum += DealerCardList[i].Value;

            if (DealerHandSum > 21) foreach (var c in DealerCardList) if (c.Value == 11)
                    {
                        // Changing Ace to 1 if soft total exceeds 21
                        DealerHandSum -= 10;
                        if (DealerHandSum <= 21) break;
                    }
        }

        internal void AddCardForPlayer()
        {

            if (PlayerCard3.Visible == false)
            {
                PlayerCard3.Visible = true;
                PlayerHandSum = 0;
                var randomCard = SelectRandomCard();
                var card = CardDeck[randomCard];
                UsedCards.Add(randomCard);

                if (UsedCards.Contains(randomCard)) randomCard = SelectRandomCard();

                PlayerCard3.ImageLocation = card.Image;
                PlayerCard3.SizeMode = PictureBoxSizeMode.StretchImage;

                Controls.Add(PlayerCard3);

                PlayerCard3.BringToFront();
                PlayerCardList.Add(card);
            }
            else if (PlayerCard4.Visible == false)
            {
                PlayerCard4.Visible = true;
                PlayerHandSum = 0;
                var randomCard = SelectRandomCard();
                var card = CardDeck[randomCard];
                UsedCards.Add(randomCard);

                if (UsedCards.Contains(randomCard)) randomCard = SelectRandomCard();

                PlayerCard4.ImageLocation = card.Image;
                PlayerCard4.SizeMode = PictureBoxSizeMode.StretchImage;
                Controls.Add(PlayerCard4);

                PlayerCard4.BringToFront();

                PlayerCardList.Add(card);
            }
            else if (PlayerCard5.Visible == false)
            {
                PlayerCard5.Visible = true;
                PlayerHandSum = 0;
                var randomCard = SelectRandomCard();
                var card = CardDeck[randomCard];
                UsedCards.Add(randomCard);

                if (UsedCards.Contains(randomCard)) randomCard = SelectRandomCard();

                PlayerCard5.ImageLocation = card.Image;
                PlayerCard5.SizeMode = PictureBoxSizeMode.StretchImage;
                Controls.Add(PlayerCard5);

                PlayerCard5.BringToFront();
                PlayerCardList.Add(card);
            }
        }

        internal bool CheckForAces()
        {
            bool flag = false;

            foreach (var c in PlayerCardList)
            {
                if (c.Value == 11)
                {
                    flag = true;
                }
            }
            return flag;
        }

        internal void DisableButtons()
        {
            StandButton.Enabled = false;
            hitMeButton.Enabled = false;
            SurrenderButton.Enabled = false;
            SplitButton.Enabled = false;
            DoubleButton.Enabled = false;
        }

        internal void EnableButtons()
        {
            StandButton.Enabled = true;
            hitMeButton.Enabled = true;
            SurrenderButton.Enabled = true;
            SplitButton.Enabled = true;
            DoubleButton.Enabled = true;
        }

        internal void SplitCards()
        {
            PlayerCard1.ImageLocation = PlayerCardList[0].Image;
            PlayerCard1.SizeMode = PictureBoxSizeMode.StretchImage;
            PlayerCard1.Location = new Point(125, 312);

            PlayerCard2.ImageLocation = PlayerCardList[1].Image;
            PlayerCard2.SizeMode = PictureBoxSizeMode.StretchImage;
            PlayerCard2.Location = new Point(427, 312);
        }


    }
}