using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SizzlingHot
{
    public static class AppConst
    {
        // control constants
        public const int _CONNECTION_REFRESH_TIME = 3000;
        public const int _USER_PASSWORD_MIN_LENGTH = 0;

        // fields constants
        public const string _MAIN_FORM_TITLE = "Shinning Crown";
        public const string _USER_LABEL_TEXT = "User:";
        public const string _PASSWORD_LABEL_TEXT = "Password:";
        public const string _BUTTON_LOGIN_TEXT = "LOGIN";
        public const string _STATUS_TEXT = "Status:";

        // info constants
        public const string _INFO_LOGGED_IN = "You've successfully logged in!";
        public const string _INFO_ACCOUNT_DONT_EXIST = "This account does not exist!";
        public const string _INFO_EMPTY_FIELDS = "User or password cannot be empty!";
        public const string _INFO_NOT_CONNECTED = "You can't log in if you're not connected!";

        // forms resolution constants
        public const int _FORM_HEIGHT = 800;
        public const int _FORM_WIDTH = 450;
    }
}
