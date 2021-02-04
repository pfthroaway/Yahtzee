using PFSoftware.Extensions;
using System.Linq;

namespace Yahtzee
{
    /// <summary>The roll of five Yahtzee dice.</summary>
    internal class Roll : BaseINPC
    {
        /// <summary>All the dice in the roll.</summary>
        public int[] Dice { get; set; } = new int[5];

        /// <summary>Total sum of all the dice.</summary>
        public int Total => Dice.Sum();

        /// <summary>Count of all the 1 dice.</summary>
        public int Aces => Dice.Count(di => di == 1);

        /// <summary>Count of all the 2 dice.</summary>
        public int Twos => Dice.Count(di => di == 2);

        /// <summary>Count of all the 3 dice.</summary>
        public int Threes => Dice.Count(di => di == 3);

        /// <summary>Count of all the 4 dice.</summary>
        public int Fours => Dice.Count(di => di == 4);

        /// <summary>Count of all the 5 dice.</summary>
        public int Fives => Dice.Count(di => di == 5);

        /// <summary>Count of all the 6 dice.</summary>
        public int Sixes => Dice.Count(di => di == 6);

        /// <summary>Sum of all the 1 dice.</summary>
        public int AcesTotal => Aces;

        /// <summary>Sum of all the 2 dice.</summary>
        public int TwosTotal => Twos * 2;

        /// <summary>Sum of all the 3 dice.</summary>
        public int ThreesTotal => Threes * 3;

        /// <summary>Sum of all the 4 dice.</summary>
        public int FoursTotal => Fours * 4;

        /// <summary>Sum of all the 5 dice.</summary>
        public int FivesTotal => Fives * 5;

        /// <summary>Sum of all the 6 dice.</summary>
        public int SixesTotal => Sixes * 6;

        /// <summary>Does the total of all the dice equal or exceed 63 to receive the upper bonus?</summary>
        public bool UpperBonus => Total >= 63;

        /// <summary>Are there any dice which have 3 or more of the same value?</summary>
        public bool ThreeOfAKind => Aces >= 3 || Twos >= 3 || Threes >= 3 || Fours >= 3 || Fives >= 3 || Sixes >= 3;

        /// <summary>Are there any dice which have 4 or more of the same value?</summary>
        public bool FourOfAKind => Aces >= 4 || Twos >= 4 || Threes >= 4 || Fours >= 4 || Fives >= 4 || Sixes >= 4;

        /// <summary>Are there 3 dice which have the same value and 2 differently valued dice that have the same?</summary>
        public bool FullHouse => ThreeOfAKind && (Aces == 2 || Twos == 2 || Threes == 2 || Fours == 2 || Fives == 2 || Sixes == 2);

        /// <summary>Are there any consecutive series of dice with 4 or more in a row?</summary>
        public bool SmallStraight => (Aces == 1 && Twos == 1 && Threes == 1 && Fours == 1) || (Twos == 1 && Threes == 1 && Fours == 1 && Fives == 1) || (Threes == 1 && Fours == 1 && Fives == 1 && Sixes == 1);

        /// <summary>Are there any consecutive series of dice with 5 in a row?</summary>
        public bool LargeStraight => (Aces == 1 && Twos == 1 && Threes == 1 && Fours == 1 && Fives == 1) || (Twos == 1 && Threes == 1 && Fours == 1 && Fives == 1 && Sixes == 1);

        /// <summary>Are there any dice which have 5 of the same value?</summary>
        public bool Yahtzee => Aces == 5 || Twos == 5 || Threes == 5 || Fours == 5 || Fives == 5 || Sixes == 5;
    }
}