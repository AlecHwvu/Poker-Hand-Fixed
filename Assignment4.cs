using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MainForm.CS
{
public partial class Assignment4 : Form
{
    private const int HAND_SIZE = 5;      // Number of cards in hand
        private const int NO_CARD = -1;
    private Deck deck;             
    private int[] hand = new int[HAND_SIZE];
    private PictureBox[] cardBoxes;
    private CheckBox[] keepBoxes; // CheckBoxes to keep cards
        public Assignment4()
{
InitializeComponent();
    cardBoxes = new PictureBox[] { picCard1, picCard2, picCard3, picCard4, picCard5 };
    keepBoxes = new CheckBox[] { chkKeep1, chkKeep2, chkKeep3, chkKeep4, chkKeep5 };
foreach (var pic in cardBoxes)
pic.Click += CardPicture_Click;
btnDeal.Click += BtnDeal_Click;
btnSave.Click += BtnSave_Click; // Event handler for Save button
            btnLoad.Click += BtnLoad_Click;
deck = new Deck(imgCards.Images.Count);
}
private void Assignment4_Load(object sender, EventArgs e)
{
    DealHand(true); // Initial deal with shuffle
        }
private void DealHand(bool newShuffle = false)
{
if (newShuffle || !keepBoxes.Any(cb => cb.Checked))
deck.Shuffle();
for (int i = 0; i < HAND_SIZE; i++)
{
if (!keepBoxes[i].Checked)
hand[i] = deck.DrawCard();
}
UpdateHandDisplay();
}
private void UpdateHandDisplay()
{
for (int i = 0; i < HAND_SIZE; i++)
{
if (hand[i] >= 0 && hand[i] < imgCards.Images.Count)    // Valid card index
                    cardBoxes[i].Image = imgCards.Images[hand[i]];
else
cardBoxes[i].Image = null;
}
}
private void CardPicture_Click(object sender, EventArgs e)
{
for (int i = 0; i < HAND_SIZE; i++)
{
if (sender == cardBoxes[i])
keepBoxes[i].Checked = !keepBoxes[i].Checked;
}
}
private void BtnDeal_Click(object sender, EventArgs e)
{
DealHand(false);
}
private void BtnSave_Click(object sender, EventArgs e)
{
using (SaveFileDialog dlg = new SaveFileDialog())
{
dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
dlg.DefaultExt = "txt";
dlg.Filter = "Text files (*.txt)|*.txt"; // Filter for text files
                if (dlg.ShowDialog() == DialogResult.OK)
{
File.WriteAllLines(dlg.FileName, hand.Select(c => c.ToString()));
MessageBox.Show("Hand saved successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
}
}
}
private void BtnLoad_Click(object sender, EventArgs e)
{
using (OpenFileDialog dlg = new OpenFileDialog())
{
dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // copilot helped add this line / document add 
                dlg.DefaultExt = "txt";
dlg.Filter = "Text files (*.txt)|*.txt";
if (dlg.ShowDialog() == DialogResult.OK)
{
string[] lines = File.ReadAllLines(dlg.FileName);
for (int i = 0; i < HAND_SIZE; i++) // copilot helped fix loading issue
                    {
if (i < lines.Length && int.TryParse(lines[i], out int cardIndex))
hand[i] = cardIndex;
else
hand[i] = NO_CARD;
keepBoxes[i].Checked = false;
}
UpdateHandDisplay();
MessageBox.Show("Hand loaded successfully!", "Load", MessageBoxButtons.OK, MessageBoxIcon.Information); // Added success message (copilot helped) just extra bonus for when loading
                }
}
}
}
public class Deck
{
private List<int> cards;
private Random rng; // Random number generator
        public Deck(int deckSize)
{
rng = new Random();
cards = Enumerable.Range(0, deckSize).ToList();
}
public void Shuffle()
{
for (int i = cards.Count - 1; i > 0; i--)
{
int j = rng.Next(i + 1);
int temp = cards[i];
cards[i] = cards[j];
cards[j] = temp;
}
}
public int DrawCard()
{
            // Return -1 if deck is empty
            if (cards.Count == 0) return -1;
    int card = cards[0];
    cards.RemoveAt(0); // Remove drawn card from deck
            return card;
}
}
}