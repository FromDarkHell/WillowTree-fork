using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WillowTree
{
    public partial class CharacterManager : Form
    {
        Form formToHide = null;
        Dictionary<string, string> addedCharacters = new Dictionary<string, string>();
        Dictionary<string, string> removedCharacters = new Dictionary<string, string>();

        public CharacterManager(Form formToHide)
        {
            InitializeComponent();
            this.formToHide = formToHide;
            this.FormClosing += new FormClosingEventHandler(formClosing);
            formToHide.Visible = false;

            Dictionary<string, string> characters = GlobalSettings.customCharacters;

            foreach (var character in characters)
            {
                var index = characterGrid.Rows.Add();
                characterGrid.Rows[index].Cells["characterNames"].Value = character.Key;
                characterGrid.Rows[index].Cells["characterClasses"].Value = character.Value;
                if (character.Value == "gd_Roland.Character.CharacterClass_Roland" || character.Value == "gd_lilith.Character.CharacterClass_Lilith" || character.Value == "gd_mordecai.Character.CharacterClass_Mordecai" || character.Value == "gd_Brick.Character.CharacterClass_Brick")
                {
                    characterGrid.Rows[index].ReadOnly = true;
                    characterGrid.Rows[index].Visible = false;
                }
            }
        }

        void formClosing(object sender, FormClosingEventArgs e)
        {
            Dictionary<string, string> characters = new Dictionary<string, string>();
            foreach (DataGridViewRow row in characterGrid.Rows)
            {
                try
                {
                    string characterName = row.Cells["characterNames"].Value.ToString();
                    string characterClass = row.Cells["characterClasses"].Value.ToString();
                    if (characterName.Trim() == "" || characterClass.Trim() == "") continue;

                    characters.Add(characterName, characterClass);
                }
                catch (NullReferenceException)
                {
                    continue;
                }
            }
            GlobalSettings.customCharacters = characters;
            GlobalSettings.Save();
            WillowTreeMain main = (WillowTreeMain)formToHide;
            main.generalTab.fixClasses(removedCharacters, addedCharacters);
            formToHide.Visible = true;
        }

        private void characterGrid_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            Dictionary<string, string> characters = new Dictionary<string, string>();
            foreach (DataGridViewRow row in characterGrid.Rows)
            {
                try
                {
                    string characterName = row.Cells["characterNames"].Value.ToString();
                    string characterClass = row.Cells["characterClasses"].Value.ToString();
                    if (characterName.Trim() == "" || characterClass.Trim() == "") continue;

                    characters.Add(characterName, characterClass);
                }
                catch (NullReferenceException)
                {
                    continue;
                }
            }
            try
            {
                addedCharacters.Add(e.Row.Cells["characterNames"].Value.ToString(), e.Row.Cells["characterClasses"].Value.ToString());
            }
            catch (NullReferenceException) { }
            GlobalSettings.customCharacters = characters;
            GlobalSettings.Save();
        }

        private void characterGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            Dictionary<string, string> characters = new Dictionary<string, string>();

            foreach (DataGridViewRow row in characterGrid.Rows)
            {
                try
                {
                    string characterName = row.Cells["characterNames"].Value.ToString();
                    string characterClass = row.Cells["characterClasses"].Value.ToString();
                    if (characterName.Trim() == "" || characterClass.Trim() == "") continue;

                    characters.Add(characterName, characterClass);
                }
                catch (NullReferenceException)
                {
                    continue;
                }
            }
            removedCharacters.Add(e.Row.Cells["characterNames"].Value.ToString(), e.Row.Cells["characterClasses"].Value.ToString());
            GlobalSettings.customCharacters = characters;
            GlobalSettings.Save();
        }
    }
}
