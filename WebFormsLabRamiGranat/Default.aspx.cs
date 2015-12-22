using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsLabRamiGranat
{
    public partial class Default : System.Web.UI.Page
    {
        static bool convertFromSek = false;
        static bool convertFromEuro = false;
        static bool convertFromPounds = false;
        static bool convertFromUSD = false;
        static bool convertFromCAD = false;

        static bool convertToSek = false;
        static bool convertToEuro = false;
        static bool convertToPounds = false;
        static bool convertToUSD = false;
        static bool convertToCAD = false;

        static string convertFrom = "";
        static string convertTo = "";

        double number1 = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["convertToCAD"] != null)
            //    convertToCAD = (bool)Session["convertToCAD"]; //check if null


        }

        protected void SekButton_Click(object sender, EventArgs e)
        {
            if (convertFromSek == false && convertFromEuro == false && convertFromPounds == false && convertFromUSD == false)
            {
                convertFromSek = true;
                convertFrom = "From Sek to";
                Result.Text = convertFrom;

                convertToCAD = false;
                convertToSek = false;
                convertToEuro = false;
                convertToPounds = false;
                convertToUSD = false;
            }
            else if (convertToSek == false && convertToEuro == false && convertToPounds == false && convertToUSD == false)
            {
                convertToSek = true;
                convertTo = " Sek";
                Result.Text = convertFrom + convertTo;
            }
            else
            {
                convertFromCAD = false;
                convertFromSek = true;
                convertFromEuro = false;
                convertFromPounds = false;
                convertFromUSD = false;

                convertToCAD = false;
                convertToSek = false;
                convertToEuro = false;
                convertToPounds = false;
                convertToUSD = false;

                convertFrom = "From Sek to";
                convertTo = "";
                Result.Text = convertFrom;
            }
            //Session["convertToCad"] = convertToCAD;
        }

        protected void EuroButton_Click(object sender, EventArgs e)
        {
            if (convertFromSek == false && convertFromEuro == false && convertFromPounds == false && convertFromUSD == false)
            {
                convertFromEuro = true;
                convertFrom = "From Euro to";
                Result.Text = convertFrom;

                convertToCAD = false;
                convertToSek = false;
                convertToEuro = false;
                convertToPounds = false;
                convertToUSD = false;
            }
            else if (convertToSek == false && convertToEuro == false && convertToPounds == false && convertToUSD == false)
            {
                convertToEuro = true;
                convertTo = " Euro";
                Result.Text = convertFrom + convertTo;
            }
            else
            {
                convertFromCAD = false;
                convertFromSek = false;
                convertFromEuro = true;
                convertFromPounds = false;
                convertFromUSD = false;

                convertToCAD = false;
                convertToSek = false;
                convertToEuro = false;
                convertToPounds = false;
                convertToUSD = false;

                convertFrom = "From Euro to";
                convertTo = "";
                Result.Text = convertFrom;
            }

        }

        protected void PoundButton_Click(object sender, EventArgs e)
        {
            if (convertFromSek == false && convertFromEuro == false && convertFromPounds == false && convertFromUSD == false)
            {
                convertFromPounds = true;
                convertFrom = "From British pounds to";
                Result.Text = convertFrom;

                convertToCAD = false;
                convertToSek = false;
                convertToEuro = false;
                convertToPounds = false;
                convertToUSD = false;
            }
            else if (convertToSek == false && convertToEuro == false && convertToPounds == false && convertToUSD == false)
            {
                convertToPounds = true;
                convertTo = " British pounds";
                Result.Text = convertFrom + convertTo;
            }
            else
            {
                convertFromCAD = false;
                convertFromSek = false;
                convertFromEuro = false;
                convertFromPounds = true;
                convertFromUSD = false;

                convertToCAD = false;
                convertToSek = false;
                convertToEuro = false;
                convertToPounds = false;
                convertToUSD = false;

                convertFrom = "From British pounds to";
                convertTo = "";
                Result.Text = convertFrom;
            }

        }

        protected void USDButton_Click(object sender, EventArgs e)
        {
            if (convertFromSek == false && convertFromEuro == false && convertFromPounds == false && convertFromUSD == false)
            {
                convertFromUSD = true;
                convertFrom = "From USD to";
                Result.Text = convertFrom;

                convertToCAD = false;
                convertToSek = false;
                convertToEuro = false;
                convertToPounds = false;
                convertToUSD = false;
            }
            else if (convertToSek == false && convertToEuro == false && convertToPounds == false && convertToUSD == false)
            {
                convertToUSD = true;
                convertTo = " USD";
                Result.Text = convertFrom + convertTo;
            }
            else
            {
                convertFromCAD = false;
                convertFromSek = false;
                convertFromEuro = false;
                convertFromPounds = false;
                convertFromUSD = true;

                convertToCAD = false;
                convertToSek = false;
                convertToEuro = false;
                convertToPounds = false;
                convertToUSD = false;

                convertFrom = "From USD to";
                convertTo = "";
                Result.Text = convertFrom;
            }

        }

        protected void CADButton_Click(object sender, EventArgs e)
        {
            if (convertFromSek == false && convertFromEuro == false && convertFromPounds == false && convertFromUSD == false)
            {
                convertFromCAD = true;
                convertFrom = "From CAD to";
                Result.Text = convertFrom;

                convertToCAD = false;
                convertToSek = false;
                convertToEuro = false;
                convertToPounds = false;
                convertToUSD = false;
            }
            else if (convertToSek == false && convertToEuro == false && convertToPounds == false && convertToUSD == false)
            {
                convertToCAD = true;
                convertTo = " CAD";
                Result.Text = convertFrom + convertTo;
            }
            else
            {
                convertFromCAD = true;
                convertFromSek = false;
                convertFromEuro = false;
                convertFromPounds = false;
                convertFromUSD = false;

                convertToCAD = false;
                convertToSek = false;
                convertToEuro = false;
                convertToPounds = false;
                convertToUSD = false;

                convertFrom = "From CAD to";
                convertTo = "";
                Result.Text = convertFrom;
            }

        }

        protected void ConvertButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Input1.Text, out number1))
            {
                if (convertFromSek == true && convertToSek == true)
                {
                    double result = number1;
                    Result.Text = convertFrom + convertTo + " = " + result.ToString();
                }
                else if (convertFromSek == true && convertToEuro == true)
                {
                    double result = number1 * 0.11;
                    Result.Text = convertFrom + convertTo + " = " + result.ToString();
                }
                else if (convertFromSek == true && convertToPounds == true)
                {
                    double result = number1 * 0.08;
                    Result.Text = convertFrom + convertTo + " = " + result.ToString();
                }
                else if (convertFromSek == true && convertToUSD == true)
                {
                    double result = number1 * 0.12;
                    Result.Text = convertFrom + convertTo + " = " + result.ToString();
                }
                else if (convertFromSek == true && convertToCAD == true)
                {
                    double result = number1 * 0.16;
                    Result.Text = convertFrom + convertTo + " = " + result.ToString();
                }
                else if (convertFromEuro == true && convertToEuro == true)
                {
                    double result = number1;
                    Result.Text = convertFrom + convertTo + " = " + result.ToString();
                }
                else if (convertFromEuro == true && convertToCAD == true)
                {
                    double result = number1 * 1.52;
                    Result.Text = convertFrom + convertTo + " = " + result.ToString();
                }
                else if (convertFromEuro == true && convertToSek == true)
                {
                    double result = number1 * 9.3;
                    Result.Text = convertFrom + convertTo + " = " + result.ToString();
                }
                else if (convertFromEuro == true && convertToPounds == true)
                {
                    double result = number1 * 0.73;
                    Result.Text = convertFrom + convertTo + " = " + result.ToString();
                }
                else if (convertFromEuro == true && convertToUSD == true)
                {
                    double result = number1 * 1.09;
                    Result.Text = convertFrom + convertTo + " = " + result.ToString();
                }
                else if (convertFromPounds == true && convertToPounds == true)
                {
                    double result = number1;
                    Result.Text = convertFrom + convertTo + " = " + result.ToString();
                }
                else if (convertFromPounds == true && convertToCAD == true)
                {
                    double result = number1 * 2.07;
                    Result.Text = convertFrom + convertTo + " = " + result.ToString();
                }
                else if (convertFromPounds == true && convertToSek == true)
                {
                    double result = number1 * 12.57;
                    Result.Text = convertFrom + convertTo + " = " + result.ToString();
                }
                else if (convertFromPounds == true && convertToEuro == true)
                {
                    double result = number1 * 1.36;
                    Result.Text = convertFrom + convertTo + " = " + result.ToString();
                }
                else if (convertFromPounds == true && convertToUSD == true)
                {
                    double result = number1 * 1.49;
                    Result.Text = convertFrom + convertTo + " = " + result.ToString();
                }
                else if (convertFromUSD == true && convertToUSD == true)
                {
                    double result = number1;
                    Result.Text = convertFrom + convertTo + " = " + result.ToString();
                }
                else if (convertFromUSD == true && convertToSek == true)
                {
                    double result = number1 * 8.45;
                    Result.Text = convertFrom + convertTo + " = " + result.ToString();
                }
                else if (convertFromUSD == true && convertToEuro == true)
                {
                    double result = number1 * 0.91;
                    Result.Text = convertFrom + convertTo + " = " + result.ToString();
                }
                else if (convertFromUSD == true && convertToPounds == true)
                {
                    double result = number1 * 0.67;
                    Result.Text = convertFrom + convertTo + " = " + result.ToString();
                }
                else if (convertFromUSD == true && convertToCAD == true)
                {
                    double result = number1 * 1.39;
                    Result.Text = convertFrom + convertTo + " = " + result.ToString();
                }
                else if (convertFromCAD == true && convertToCAD)
                {
                    double result = number1;
                    Result.Text = convertFrom + convertTo + " = " + result.ToString();
                }
                else if (convertFromCAD == true && convertToSek)
                {
                    double result = number1 * 6.08;
                    Result.Text = convertFrom + convertTo + " = " + result.ToString();
                }
                else if (convertFromCAD == true && convertToEuro)
                {
                    double result = number1 * 0.66;
                    Result.Text = convertFrom + convertTo + " = " + result.ToString();
                }
                else if (convertFromCAD == true && convertToPounds)
                {
                    double result = number1 * 0.48;
                    Result.Text = convertFrom + convertTo + " = " + result.ToString();
                }
                else if (convertFromCAD == true && convertToUSD)
                {
                    double result = number1 * 0.72;
                    Result.Text = convertFrom + convertTo + " = " + result.ToString();
                }
            }
            else
            {
                Result.Text = "You did not input a number!";
            }
        }
    }
}