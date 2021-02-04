using PFSoftware.Extensions;

namespace Yahtzee
{
    /// <summary>Represents a scorecard in the game of Yahtzee.</summary>
    public class Scorecard : BaseINPC
    {
        private int _aces, _twos, _threes, _fours, _fives, _sixes, _upperBonus, _threeOfAKind, _fourOfAKind, _fullHouse, _smallStraight, _largeStraight, _yahtzee, _chance, _yahtzeeBonus, _upperTotal, _lowerTotal, _total;

        /// <summary>The value of the Aces score.</summary>
        public int Aces
        {
            get => _aces;
            set
            {
                _aces = value;
                NotifyPropertyChanged(nameof(Aces), nameof(UpperTotal), nameof(Total));
            }
        }

        /// <summary>The value of the Twos score.</summary>
        public int Twos
        {
            get => _twos;
            set { _twos = value; NotifyPropertyChanged(nameof(Twos), nameof(UpperTotal), nameof(Total)); }
        }

        /// <summary>The value of the Threes score.</summary>
        public int Threes
        {
            get => _threes;
            set { _threes = value; NotifyPropertyChanged(nameof(Threes), nameof(UpperTotal), nameof(Total)); }
        }

        /// <summary>The value of the Fours score.</summary>
        public int Fours
        {
            get => _fours;
            set { _fours = value; NotifyPropertyChanged(nameof(Fours), nameof(UpperTotal), nameof(Total)); }
        }

        /// <summary>The value of the Fives score.</summary>
        public int Fives
        {
            get => _fives;
            set { _fives = value; NotifyPropertyChanged(nameof(Fives), nameof(UpperTotal), nameof(Total)); }
        }

        /// <summary>The value of the Sixes score.</summary>
        public int Sixes
        {
            get => _sixes;
            set { _sixes = value; NotifyPropertyChanged(nameof(Sixes), nameof(UpperTotal), nameof(Total)); }
        }

        /// <summary>The value of the Upper Bonus score.</summary>
        public int UpperBonus
        {
            get => _upperBonus;
            set { _upperBonus = value; NotifyPropertyChanged(nameof(UpperBonus), nameof(UpperTotal), nameof(Total)); }
        }

        /// <summary>The value of the Three of a Kind score.</summary>
        public int ThreeOfAKind
        {
            get => _threeOfAKind;
            set { _threeOfAKind = value; NotifyPropertyChanged(nameof(ThreeOfAKind), nameof(LowerTotal), nameof(Total)); }
        }

        /// <summary>The value of the Four of a Kind score.</summary>
        public int FourOfAKind
        {
            get => _fourOfAKind;
            set { _fourOfAKind = value; NotifyPropertyChanged(nameof(FourOfAKind), nameof(LowerTotal), nameof(Total)); }
        }

        /// <summary>The value of the Full House score.</summary>
        public int FullHouse
        {
            get => _fullHouse;
            set { _fullHouse = value; NotifyPropertyChanged(nameof(FullHouse), nameof(LowerTotal), nameof(Total)); }
        }

        /// <summary>The value of the Small Straight score.</summary>
        public int SmallStraight
        {
            get => _smallStraight;
            set { _smallStraight = value; NotifyPropertyChanged(nameof(SmallStraight), nameof(UpperTotal), nameof(Total)); }
        }

        /// <summary>The value of the Large Straight score.</summary>
        public int LargeStraight
        {
            get => _largeStraight;
            set { _largeStraight = value; NotifyPropertyChanged(nameof(LargeStraight), nameof(LowerTotal), nameof(Total)); }
        }

        /// <summary>The value of the Yahtzee score.</summary>
        public int Yahtzee
        {
            get => _yahtzee;
            set { _yahtzee = value; NotifyPropertyChanged(nameof(Yahtzee), nameof(LowerTotal), nameof(Total)); }
        }

        /// <summary>The value of the Chance score.</summary>
        public int Chance
        {
            get => _chance;
            set { _chance = value; NotifyPropertyChanged(nameof(Chance), nameof(LowerTotal), nameof(Total)); }
        }

        /// <summary>The value of the Yahtzee Bonus score.</summary>
        public int YahtzeeBonus
        {
            get => _yahtzeeBonus;
            set { _yahtzeeBonus = value; NotifyPropertyChanged(nameof(YahtzeeBonus), nameof(LowerTotal), nameof(Total)); }
        }

        /// <summary>The combined value of the upper section scores.</summary>
        public int UpperTotal
        {
            get => _upperTotal;
            set { _upperTotal = value; NotifyPropertyChanged(nameof(UpperTotal), nameof(Total)); }
        }

        /// <summary>The combined value of the lower section scores.</summary>
        public int LowerTotal
        {
            get => _lowerTotal;
            set { _lowerTotal = value; NotifyPropertyChanged(nameof(LowerTotal), nameof(Total)); }
        }

        /// <summary>The combined value of all the scores.</summary>
        public int Total
        {
            get => _total;
            set { _total = value; NotifyPropertyChanged(nameof(Total)); }
        }

        /// <summary>Has the Ones score already been filled?</summary>
        public bool OnesUsed { get; set; }

        /// <summary>Has the Twos score already been filled?</summary>
        public bool TwosUsed { get; set; }

        /// <summary>Has the Threes score already been filled?</summary>
        public bool ThreesUsed { get; set; }

        /// <summary>Has the Fours score already been filled?</summary>
        public bool FoursUsed { get; set; }

        /// <summary>Has the Fives score already been filled?</summary>
        public bool FivesUsed { get; set; }

        /// <summary>Has the Sixes score already been filled?</summary>
        public bool SixesUsed { get; set; }

        /// <summary>Has the Three of a Kind score already been filled?</summary>
        public bool ThreeOfAKindUsed { get; set; }

        /// <summary>Has the Four of a Kind score already been filled?</summary>
        public bool FourOfAKindUsed { get; set; }

        /// <summary>Has the Full House score already been filled?</summary>
        public bool FullHouseUsed { get; set; }

        /// <summary>Has the Small Straight score already been filled?</summary>
        public bool SmallStraightUsed { get; set; }

        /// <summary>Has the Large Straight score already been filled?</summary>
        public bool LargeStraightUsed { get; set; }

        /// <summary>Has the Yahtzee score already been filled?</summary>
        public bool YahtzeeUsed { get; set; }

        /// <summary>Has the Chance score already been filled?</summary>
        public bool ChanceUsed { get; set; }

        /// <summary>Initializes a new instance of <see cref="Scorecard"/>.</summary>
        public Scorecard()
        {
        }
    }
}