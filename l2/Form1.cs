using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using l2.Tools;
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace l2
{
    // 13 - 14 number 
    public partial class Form1 : MaterialForm
    {
        Payment payment;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            payment = new Payment();
            L3 l3 = new L3();
            l3.Add("1");
            l3.Add("2");
            l3.Add("4");
            Console.Write(l3[0]);
            Console.Write(l3[1]);
            l3[1] = "C#";
            Console.Write(l3[1]);
            l3.Print();

            Tools.Delegate processor = new Tools.Delegate();
            MessageHandler textHandler = new MessageHandler(processor.ProcessTextMessage);
            MessageHandler imageHandler = new MessageHandler(processor.ProcessImageMessage);
            MessageHandler videoHandler = new MessageHandler(processor.ProcessVideoMessage);

            MessageHandler textHandler_1 = delegate (string message) {
                Console.WriteLine($"Processing text message: {message}");
                processor.AddMessage(message);
            };

            MessageHandler imageHandler_1 = delegate (string message) {
                Console.WriteLine($"Processing image message: {message}");
                processor.AddMessage($"Image: {message}");
            };

            MessageHandler videoHandler_1 = delegate (string message) {
                Console.WriteLine($"Processing video message: {message}");
                processor.AddMessage($"Video: {message}");
            };

            textHandler("He");
            imageHandler("image.png");
            imageHandler_1("imagerrew.png");
            videoHandler_1("video123.mp4");

            MessageHandler currentHandler = textHandler;
            currentHandler("Dynamic text message");

            currentHandler = imageHandler;
            currentHandler("Dynamic image message");

            currentHandler = videoHandler;
            currentHandler("Dynamic video message");

        }

        private void materialButtonAddNewClient_Click(object sender, EventArgs e)
        {
            string name = materialTextBoxName.Text;
            string address = materialTextBoxAddress.Text;
            
            Client client = new Client(name:name, address:address);

            var paymentClient = payment.Clients;
            paymentClient.Add(client);


            materialComboBoxClients.Items.Clear();
            materialComboBox2.Items.Clear();
            materialComboBoxClients.Items.AddRange(paymentClient.ToArray());
            materialComboBox2.Items.AddRange(paymentClient.ToArray());


        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string number = materialTextBoxInputCreditCard.Text;
            CreditCard card = new CreditCard(number: number);

            var paymentClient = payment.CreditCards;
            paymentClient.Add(card);


            materialComboBox1.Items.Clear();
            materialComboBox1.Items.AddRange(paymentClient.ToArray());


            materialComboBoxClientListCards.Items.Clear();
            materialComboBoxClientListCards.Items.AddRange(paymentClient.ToArray());


        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            string name = materialTextBoxBancAccount.Text;
            BankAccount bankAccount = new BankAccount(name);
            var paymentClient = payment.BankAccounts;
            paymentClient.Add(bankAccount);


            materialComboBoxClientBankAccountList.Items.Clear();
            materialComboBoxClientBankAccountList.Items.AddRange(paymentClient.ToArray());
            materialComboBoxListAllBankAccount.Items.Clear();
            materialComboBoxListAllBankAccount.Items.AddRange(paymentClient.ToArray());
        }

        private void materialComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            var client = ((Client)((MaterialComboBox)sender).SelectedItem);
            if (client is null) return;
            materialTextBox3.Text = client.Address;
            materialComboBoxClientListCards.SelectedItem = client.Card;
            materialComboBoxClientBankAccountList.SelectedItem = client.BankAccount;


        }

        private void materialComboBoxClientListCards_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialButtonUpdateClient_Click(object sender, EventArgs e)
        {
            var client = (Client)(materialComboBox2.SelectedItem);
            client.Address = materialTextBox3.Text;
            client.Card = (CreditCard)materialComboBoxClientListCards.SelectedItem;
            client.BankAccount = (BankAccount)materialComboBoxClientBankAccountList.SelectedItem;
        }

        private void materialButtonBlockCard_Click(object sender, EventArgs e)
        {
            var creditCard = ((CreditCard)((MaterialComboBox)sender).SelectedItem);
            if (creditCard is null) return;

            foreach (var item in payment.Clients)
            {
                if (item.Card.Number == creditCard.Number)
                {
                    item.blockCredirCard();
                }
            }
        }

        private void materialButtonClientBlockCard_Click(object sender, EventArgs e)
        {
            var client = (Client)(materialComboBox2.SelectedItem);
            if (client is null) return;

            client.blockCredirCard();
        }
    }
}
