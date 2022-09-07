using SeleniumExtras.PageObjects;

namespace FlipCart.PageObject
{
    internal class FindsByAttribute : Attribute
    {
        public string Using { get; set; }
        public How How { get; set; }
    }
}