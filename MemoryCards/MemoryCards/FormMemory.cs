using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryCards
{
	public partial class FormMemory : Form
	{
		static Random rand = new Random();
		int[] cards = new int[16];
		bool[] opens = new bool[16];
		int done;
		int status;
		int cardA;
		int cardB;
		public FormMemory()
		{
			InitializeComponent();
			InitGame();
		}

		private void menuGameExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void menuRules_Click(object sender, EventArgs e)
		{
			MessageBox.Show(@"Цель игры -открыть все карточки за минимальное количество ходов

На столе лежит 16 перевернутых карточек.
На них 8 разных картинок.
Необходимо найти парные картинки");
		}

		private void menuInfo_Click(object sender, EventArgs e)
		{
			MessageBox.Show(@"Автор Владимир Добржанский");
		}

		private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
		{
			Int32.TryParse(((PictureBox)sender).Tag.ToString(), out int nr);
			if (opens[nr]) return;
			switch (status)
			{
				case 0:Status_0(nr);break;
				case 1: Status_1(nr); break;
				case 2: Status_2(); break;
				case 3: Status_3(nr); break;
				default:break;
			}
		}
		private void InitGame()
		{
			for (int i = 0; i < cards.Length; i++)
			{
				cards[i] = i % (cards.Length / 2) + 1;
			}
			for (int i = 0; i < 100; i++)
			{
				ShuffleCards();
			}
			for (int i = 0; i < cards.Length; i++)
			{
				LoadPicture(i, 0);
			}
			for (int i = 0; i < cards.Length; i++)
			{
				Hide(i);
			}
			for (int i = 0; i < cards.Length; i++)
			{
				opens[i] = false;
			}
			done = 0;
			status = 0;

		}
		private void Show(int picture)
		{
			LoadPicture(picture, cards[picture]);
			GetPictureBox(picture).Cursor = Cursors.Arrow;
		}
		private void Open(int picture)
		{
			opens[picture] = true;
			Show(picture);
		}
		private void Hide(int picture)
		{
			LoadPicture(picture, 0);
			GetPictureBox(picture).Cursor = Cursors.Hand;
		}
		private void ShuffleCards()
		{
			int a = rand.Next(0, cards.Length);
			int b = rand.Next(0, cards.Length);
			if (a == b) return;
			int x = cards[a];
			cards[a] = cards[b];
			cards[b] = x;

		}
		private void LoadPicture(int picture, int image)
		{
			GetPictureBox(picture).Image = GetImage(image);
		}
		private PictureBox GetPictureBox(int picture)
		{
			switch (picture)
			{
				case 0: return pictureBox0;
				case 1: return pictureBox1;
				case 2: return pictureBox2;
				case 3: return pictureBox3;
				case 4: return pictureBox4;
				case 5: return pictureBox5;
				case 6: return pictureBox6;
				case 7: return pictureBox7;
				case 8: return pictureBox8;
				case 9: return pictureBox9;
				case 10: return pictureBox10;
				case 11: return pictureBox11;
				case 12: return pictureBox12;
				case 13: return pictureBox13;
				case 14: return pictureBox14;
				case 15: return pictureBox15;
				default: return null;
			}
		}
		private Image GetImage(int image)
		{
			switch (image)
			{
				case 0: return Properties.Resources._0;
				case 1: return Properties.Resources._1;
				case 2: return Properties.Resources._2;
				case 3: return Properties.Resources._3;
				case 4: return Properties.Resources._4;
				case 5: return Properties.Resources._5;
				case 6: return Properties.Resources._6;
				case 7: return Properties.Resources._7;
				case 8: return Properties.Resources._8;
				default: return null;
			}
		}

		private void menuGameNew_Click(object sender, EventArgs e)
		{
			InitGame();
		}
		private void Status_0(int nr)
		{
			cardA = nr;
			Show(cardA);
			status = 1;
		}
		private void Status_1(int nr)
		{
			cardB = nr;
			if (cardA == cardB) return;
			Show(cardB);
			
			if (cards[cardA] == cards[cardB])
			{
				Open(cardA);
				Open(cardB);
				done += 2;
				if (done == 16)
				{
					YouWin();
				}
				else
				{
					status = 0;
				}
			}
			else
			{
				status = 3;
			}
			
		}
		private void Status_2()
		{

		}
		private void Status_3(int nr)
		{
			Hide(cardA);
			Hide(cardB);
			Status_0(nr);
			
		}
		private void YouWin()
		{
			MessageBox.Show("Поздравляю,вы победили");
		}
	}
}
