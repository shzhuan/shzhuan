using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace View.Role {
    public class AttributeChangeInfo : MonoBehaviour {
        public Text favorNum;
        public Text loyaltyNum;
        public Text forceNum;
        public Text mentalityNum;
        public Text charismaNum;
        

        public void SetData(Model.PropData data) {

        }

        private string NumberToChineseNumber(int num) {
            string chineseNumber = "";
            int numberLength = num.ToString().Length;
            switch (numberLength) {
                case 1:
                    chineseNumber = UnitsDigitToChineseNumber(num);
                    break;
                case 2:
                    int tensdigit = num / 10;
                    int UnitsDigit = num % 10;
                    chineseNumber = UnitsDigitToChineseNumber(tensdigit) + "拾";
                    if (UnitsDigit != 0) {
                        chineseNumber = chineseNumber + UnitsDigitToChineseNumber(UnitsDigit);
                    }
                    break;
                case 3:
                    int hundredsDigit = num / 100;
                    tensdigit = num % 100 / 10;
                    UnitsDigit = num % 100 % 10;
                    chineseNumber = UnitsDigitToChineseNumber(hundredsDigit) + "佰";
                    if (tensdigit == 0 && UnitsDigit != 0) {
                        chineseNumber = chineseNumber + UnitsDigitToChineseNumber(tensdigit) +
                            UnitsDigitToChineseNumber(UnitsDigit);
                    } else if (tensdigit != 0 && UnitsDigit == 0) {
                        chineseNumber = chineseNumber + UnitsDigitToChineseNumber(tensdigit) + "拾";
                    } else if (tensdigit != 0 && UnitsDigit != 0) {
                        chineseNumber = chineseNumber + UnitsDigitToChineseNumber(tensdigit) + "拾" + 
                            UnitsDigitToChineseNumber(UnitsDigit);
                    }
                    break;
                default:
                    chineseNumber = "Error";
                    break;
            }
            return chineseNumber;
        }

        private string UnitsDigitToChineseNumber(int num) {
            string unitsDigit = "";
            switch (num) {
                case 0:
                    unitsDigit = "零";
                    break;
                case 1:
                    unitsDigit = "壹";
                    break;
                case 2:
                    unitsDigit = "貳";
                    break;
                case 3:
                    unitsDigit = "叁";
                    break;
                case 4:
                    unitsDigit = "肆";
                    break;
                case 5:
                    unitsDigit = "伍";
                    break;
                case 6:
                    unitsDigit = "陸";
                    break;
                case 7:
                    unitsDigit = "柒";
                    break;
                case 8:
                    unitsDigit = "捌";
                    break;
                case 9:
                    unitsDigit = "玖";
                    break;
                default:
                    unitsDigit = "Error";
                    break;
            }
            return unitsDigit;
        }

    }
}
