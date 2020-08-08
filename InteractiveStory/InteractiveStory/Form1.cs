using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace InteractiveStory
{
    public partial class FormMain : Form
    {
        //Variable will be used for choices being made from the drop down
        int newChoice;
        //Variable to hold players name to display in story
        string name;
        //Variable is used to keep track of health and used in losehealth method
        int health = 100;
        //List of strings for items that will be in the inventory
        List<string> inventory = new List<String> ();
        //Create an object for playing intro sounds
        SoundPlayer introSoundPlayer = new SoundPlayer(Properties.Resources.Killer_Movie_Scene_Sound);
        //Create an object for playing inventory add noises
        SoundPlayer inventoryOpenSoundPlayer = new SoundPlayer(Properties.Resources.leather_inventory);
        //Create an object for playing inventory closes noise
        SoundPlayer inventoryCloseSoundPlayer = new SoundPlayer(Properties.Resources.cloth_inventory);
        //Create an object for playing zombie sounds
        SoundPlayer zombieSoundPlayer = new SoundPlayer(Properties.Resources.Enraged_Zombies);
        public FormMain()
        {
            InitializeComponent();
            //Play intro sound
            introSoundPlayer.Play();
            ContinueStoryButton.Enabled = false;
        }
        //Method is used to take in the players name and start the story
        private void EnterInput_Click(object sender, EventArgs e)
        {
            //Get players name
            name = InputTextBox.Text;
            //Start story
            StartStory(name);
            
        }
        //This method is used for the combo box to allow the player to make a decision
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Using the variable we created up top to keep track of what index we are at
            newChoice = comboBox1.SelectedIndex;
            //This calls the Decision method
            Decision();
            //Stop playing intro sound
            introSoundPlayer.Stop();
        }
        //This method is used to take away the players health. It returns the health at the end of the method and passes in health as a parameter
        private int LoseHealth(int loseHealth)
        {
            //Set health equal to zero
            health = 0;
            //Display to the user that they have no health remaining and may exit the application
            StoryTextBox.Text = "You have lost all of your health and have now died and turned into a zombie. You may now exit the application";
            //Return health
            return health;
        }
        //This method starts the story the player will embark on. It returns the name of the player at the end of the method and also passing in the name as a parameter
        private string StartStory(string playerName)
        {
            //Change the background image to SupplyRun which is in the resource folder
            this.BackgroundImage = Properties.Resources.SupplyRun;
            //Display the player the story using their name they have entered
            StoryTextBox.Text = name + " has been choosen to go on a supply run. There is a store not to far from camp that should still have supplies. " + 
                name + " will be going with Tom and Suzie. All of you may take whatever you need to survive the supply run.Good luck and God speed. " +
                "You will have to make a decision once you arrive at the store.";
            
            //Tell the player they have arrived at the store
            MessageBox.Show("You have arrived at the store. Use the options drop down to continue");
            //Play inventory open sound
            inventoryOpenSoundPlayer.Play();
            //Add items to inventory for reaching the store
            inventory.Add("Canned Beef");
            inventory.Add("Rubbing Alcohol");
            inventory.Add("Tylenol");
            inventory.Add("AR-15");
            inventory.Add("First Aid Kit");
            //Let the player know items have been added to their inventory
            MessageBox.Show("You have items that have been added to your inventory");
            //Play inventory close sound
            inventoryCloseSoundPlayer.Play();
            //Set the button to now be interactable now that their are items in the inventory
            DisplayInventory.Enabled = true;
            //Change the background image to match to the store located in the resource folder
            this.BackgroundImage = Properties.Resources.Store;
            //Return the name of the player
            return name;
        }
        //This method is used for the decision the player will make
        //Depending on what option they picked in the drop down will depend on what outcome they get
        private void Decision()
        {
            //If the player picks the first item in the drop down
            if(newChoice == 0)
            {
                //Show the first case in continuestory
                ContinueStory(1);
            }
            //If the player picks the second item in the drop down
            else if(newChoice == 1)
            {
                //Show the second case in continuestory
                ContinueStory(2);
            }
            //If the player picks the third item in the drop down
            else if(newChoice == 2)
            {
                //Show the third case in continuestory
                ContinueStory(3);
            }
        }
        private void ContinueStory(int index)
        {
            //Change background image to match zombiefight found in resource folder
            this.BackgroundImage = Properties.Resources.ZombieFight;
            //Tell the user they have looted everything and zombies are spotted
            StoryTextBox.Text = "You guys have gotten to the store and looted everything. Tom notices a horde of zombies approaching from the street.";
            //Switch for the different outcomes related to what decision the player has made
            switch (index)
            {
                //If the player has picked the first item in the drop down this is their story
                case 1:
                    //Display story
                    StoryTextBox.Text = "You have decided to fight the horde. You all take apportiate positions to fend off the horde. " +
                        "You are able to fend them off for a short time but all of you run out of bullets. " +
                        "There is nothing left for you guys to do except to accept fate.";
                    //Play zombie sound
                    zombieSoundPlayer.Play();
                    //Call the LoseHealth method to let the player know they have died
                    LoseHealth(health);
                    //Thank the player for playing and that they can now exit
                    MessageBox.Show("Thank you for playing the simulation is now over you may exit the application now");
                    break;
                //If the player has picked the second item in the drop down this is their story
                case 2:
                    //Display Story
                    StoryTextBox.Text = "You have decided to run from the horde. You make it down the street and think all of you are getting away. " +
                        "You turn a street corner and realize you are surrounded though and have no where to go. " +
                        "You try fighting at this point but are overwhelmed. "+
                        "Please press continue story to keep going.";
                    //Play zombie sound
                    zombieSoundPlayer.Play();
                    //Enable button to continue story
                    ContinueStoryButton.Enabled = true;
                    break;
                //If the player has picked the third item in the drop down this is their story
                case 3:
                    //Display story
                    StoryTextBox.Text = "You have decided to hide from the horde. " +
                        "All of you find a good spot in a warehouse to hide for the time being. " +
                        "Something in the warehouse makes a loud crashing noise though and alerts the horde. " +
                        "You are now trapped in a warehouse with the horde closing in. " +
                        "You all try to fight for your lives but it is not enough. " +
                        "Please press continue story to keep going.";
                    //Enable button to continue story
                    ContinueStoryButton.Enabled = true;
                    break;
            }
        }
        //Display the items the player has in the inventory when the button is clicked
        private void DisplayInventory_Click(object sender, EventArgs e)
        {
            //Cycle through the list<> inventory to display items in the list
            foreach(string item in inventory)
            {
                //Print out the items that are in the list
                StoryTextBox.Text = StoryTextBox.Text + "\n This item has been found in your inventory : " + item + ".";
            }
        }
        //Continue story button to open new form
        private void ContinueStoryButton_Click(object sender, EventArgs e)
        {
            //Hide form
            this.Hide();
            //create object for new form
            Form2 openForm = new Form2();
            //open new form
            openForm.Show();
        }
    }
}