using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneBookApp.Enum;

namespace TelephoneBookApp.Classes
{
    public class TelephoneBook
    {
        public List<Entry> Entries { get; private set; }
        public string FullText { get; private set; }

        private List<string> _lines;
        private string _nameText;
        private string _telephoneNumberText;
        private string _adressText;

        private int _largestNameLength;
        private int _largestTelephoneNumberLength;
        private int _largestAdressLength;

        private int _horizontalDividorAmount;

        public TelephoneBook()
        {
            Entries = new List<Entry>();
            _lines = new List<string>();

            _nameText = "Naam";
            _telephoneNumberText = "Telefoonnummer";
            _adressText = "Adres";

            _largestNameLength = 0;
            _largestTelephoneNumberLength = 0;
            _largestAdressLength = 0;

            _horizontalDividorAmount = 2;
        }

        public void AddEntry(string name, string telephoneNumber, string adress)
        {
            Entries.Add(new Entry(name, telephoneNumber, adress));
        }

        public void AddEntry(Entry entry)
        {
            Entries.Add(entry);
        }

        public void Sort(EntryItemType entryItemType)
        {
            switch (entryItemType)
            {
                case EntryItemType.NAME:
                    Entries = Entries.OrderBy(entry => entry.Name).ToList();
                    break;

                case EntryItemType.TELEPHONE_NUMBER:
                    Entries = Entries.OrderBy(entry => entry.TelephoneNumber).ToList();
                    break;

                case EntryItemType.ADRESS:
                    Entries = Entries.OrderBy(entry => entry.Adress).ToList();
                    break;
            }
        }

        public void CompileList()
        {
            _largestNameLength = GetLargestStringSizeInEntries(EntryItemType.NAME);
            _largestTelephoneNumberLength = GetLargestStringSizeInEntries(EntryItemType.TELEPHONE_NUMBER);
            _largestAdressLength = GetLargestStringSizeInEntries(EntryItemType.ADRESS);
            _lines.Clear();

            var builder = new StringBuilder();
            char currentChar = ' ';

            builder.Append('┌');
            builder.Append(string.Empty.PadRight(_largestNameLength, '─'));
            builder.Append('┬');
            builder.Append(string.Empty.PadRight(_largestTelephoneNumberLength, '─'));
            builder.Append('┬');
            builder.Append(string.Empty.PadRight(_largestAdressLength, '─'));
            builder.Append('┐');

            // adding first line
            _lines.Add(builder.ToString());

            builder.Clear();

            // create heading
            string heading = CreateTableHeading();
            _lines.Add(heading);

            List<Entry> sortedEntries = Entries.OrderBy(entry => entry.Name).ToList();

            // Go through each entry and add it to the table
            sortedEntries.ForEach(entry =>
            {
                string nameUppercase = entry.Name.ToUpper();

                // check if a character heading needs to be created
                if (nameUppercase[0] != currentChar)
                {
                    currentChar = nameUppercase[0];

                    string charHeader = CreateLetterHeader(currentChar);

                    builder.Append(charHeader);
                }

                builder.Append('│');
                builder.Append(entry.Name.PadRight(_largestNameLength, ' '));
                builder.Append('│');
                builder.Append(entry.TelephoneNumber.PadRight(_largestTelephoneNumberLength, ' '));
                builder.Append('│');
                builder.Append(entry.Adress.PadRight(_largestAdressLength, ' '));
                builder.Append('│');

                _lines.Add(builder.ToString());

                builder.Clear();
            });

            builder.Append('└');
            builder.Append(string.Empty.PadRight(_largestNameLength, '─'));
            builder.Append('┴');
            builder.Append(string.Empty.PadRight(_largestTelephoneNumberLength, '─'));
            builder.Append('┴');
            builder.Append(string.Empty.PadRight(_largestAdressLength, '─'));
            builder.Append('┘');

            _lines.Add(builder.ToString());

            FullText = LinesToFullText();
            //Console.WriteLine(FullText);
        }

        /// <summary>
        /// Createas a header for a character
        /// </summary>
        /// <param name="character">Character to put in the heading</param>
        /// <returns>string containing the header</returns>
        private string CreateLetterHeader(char character)
        {
            // calculate innerWidth of table and subtract one to make place for the character
            int innerWidth = _largestNameLength + _largestTelephoneNumberLength + _largestAdressLength + _horizontalDividorAmount - 1;

            var builder = new StringBuilder();

            // create top part of heading
            builder.Append('├');
            builder.Append(String.Empty.PadRight(_largestNameLength, '─'));
            builder.Append('┴');
            builder.Append(String.Empty.PadRight(_largestTelephoneNumberLength, '─'));
            builder.Append('┴');
            builder.Append(String.Empty.PadRight(_largestAdressLength, '─'));
            builder.Append('┤');
            builder.Append('\n');

            // create middle part
            builder.Append('│');
            builder.Append(character);
            builder.Append(String.Empty.PadRight(innerWidth, ' '));
            builder.Append('│');
            builder.Append('\n');

            // create bottom part
            builder.Append('├');
            builder.Append(String.Empty.PadRight(_largestNameLength, '─'));
            builder.Append('┬');
            builder.Append(String.Empty.PadRight(_largestTelephoneNumberLength, '─'));
            builder.Append('┬');
            builder.Append(String.Empty.PadRight(_largestAdressLength, '─'));
            builder.Append('┤');
            builder.Append('\n');

            return builder.ToString();
        }
            
        /// <summary>
        /// Create a heading for the table
        /// </summary>
        /// <returns>Heading</returns>
        private string CreateTableHeading()
        {
            var builder = new StringBuilder();

            builder.Append('│');
            builder.Append("Naam".PadRight(_largestNameLength, ' '));
            builder.Append('│');
            builder.Append("Telefoonnummer".PadRight(_largestTelephoneNumberLength, ' '));
            builder.Append('│');
            builder.Append("Adres".PadRight(_largestAdressLength, ' '));
            builder.Append('│');

            return builder.ToString();
        }

        /// <summary>
        /// Puts all created lines into one string.
        /// </summary>
        /// <returns>String containing all lines</returns>
        private string LinesToFullText()
        {
            var builder = new StringBuilder();

            _lines.ForEach(line => builder.Append($"{line}\n"));

            return builder.ToString();
        }

        /// <summary>
        /// Gets the largest string size in the entries list of a given type
        /// </summary>
        /// <param name="entryItemType">Type of entry to search for</param>
        /// <returns>Largest size found.</returns>
        private int GetLargestStringSizeInEntries(EntryItemType entryItemType)
        {
            int largestStringSize = 0;

            // Go through each entry and figure out what the largest of the strings is
            Entries.ForEach(entry =>
            {
                switch (entryItemType)
                {
                    case EntryItemType.NAME:

                        if (largestStringSize == 0)
                            largestStringSize = _nameText.Length;

                        if (entry.Name.Length > largestStringSize)
                            largestStringSize = entry.Name.Length;
                        break;

                    case EntryItemType.TELEPHONE_NUMBER:

                        if (largestStringSize == 0)
                            largestStringSize = _telephoneNumberText.Length;

                        if (entry.TelephoneNumber.Length > largestStringSize)
                            largestStringSize = entry.TelephoneNumber.Length;
                        break;

                    case EntryItemType.ADRESS:

                        if (largestStringSize == 0)
                            largestStringSize = _adressText.Length;

                        if (entry.Adress.Length > largestStringSize)
                            largestStringSize = entry.Adress.Length;
                        break;
                }
            });

            return largestStringSize;
        }
    }
}
