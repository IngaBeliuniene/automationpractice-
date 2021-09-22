using NUnit.Framework;

namespace Darbas.Test
{
    public class PresvikaTest : BaseTest
    {
        [Test]

        public static void OrderPaymentByCheque()
        {
            _HomePage.NavigateToPage();
            _HomePage.SearchByWord("Faded Short Sleeve T-shirts");
            _SearchResultPage.VerifyAddToChartResult();
            _SearchResultPage.AddToChartByIcon();
            _ShoppingBagPage.VerifyShoppingBagResult();
            _PersonalInformationPage.InputEmail("Zmogus1@gmail.com");
            _PersonalInformationPage.PersonalInfoInputField("Zmogausvardas", "Netikras", "Zmogus1@gmail.com", "bugiss11",
                                                            "Sunset str. 81-222 ", "Vilnius");
            _PersonalInformationPage.RegistrationokConfirmation();
            _OrderConfirmationPage.FinishorderByCheck();
        }
        [Test]
        public static void OrderPaymentByBank()
        {
            _HomePage.NavigateToPage();
            _HomePage.SearchByWord("Faded Short Sleeve T-shirts");
            _SearchResultPage.VerifyAddToChartResult();
            _SearchResultPage.AddToChart();
            _ShoppingBagPage.VerifyShoppingBagResult();
            _PersonalInformationPage.InputEmail("Vidas1@gmail.com");
            _PersonalInformationPage.PersonalInfoInputField("Vidass", "Kazkokss", "Vidas1@gmail.com", "vugiss11",
                                                            "Sunset str. 92-313 ", "Vilnius");
            _PersonalInformationPage.RegistrationokConfirmation();
            _OrderConfirmationPage.FinishorderByBank();

        }
    }
}
