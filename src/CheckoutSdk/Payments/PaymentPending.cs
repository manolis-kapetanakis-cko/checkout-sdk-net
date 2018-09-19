using Checkout.Common;
using Newtonsoft.Json;

namespace Checkout.Payments
{
    public class PaymentPending : Resource
    {
        public string Id { get; set; }
        public string Status { get; set; }
        public string Reference { get; set; }
        public Customer Customer { get; set; }
        public int? Amount { get; set; }
        public string Currency { get; set; }

        [JsonProperty(PropertyName = "3ds")]
        public ThreeDsEnrollment ThreeDs { get; set; }
        public bool RequiresRedirect() => HasLink("redirect");
        public Link GetRedirectLink() => GetLink("redirect");
    }
}