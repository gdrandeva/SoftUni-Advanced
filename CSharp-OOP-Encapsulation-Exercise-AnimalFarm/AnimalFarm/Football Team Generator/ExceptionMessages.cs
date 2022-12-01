using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Team_Generator
{
    public static class ExceptionMessages
    {
        public const string NameCannotBeNullOrWhiteSpace = "A name should not be empty.";

        public const string InvalidStatMessage = "{0} should be between 0 and 100.";

        public const string MissingPlayerMessage = "Player {0} is not in {1} team.";

    }
}
