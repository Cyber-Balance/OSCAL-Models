using AutoBogus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nist.Oscal.Tests.Bogus
{
    public class TelephoneNumberFaker : AutoFaker<Models.Core.TelephoneNumber>
    {
        public TelephoneNumberFaker()
        {
            RuleFor(t => t.Type, f => f.PickRandom("home", "office", "mobile"));
            RuleFor(t => t.Number, (f, u) =>
            {
                var phone = f.Phone.PhoneNumber();
                var i = phone.IndexOf("x");

                return (u.Type == "office" || i == -1) ? phone : phone.Remove(i).Trim();
            });
        }
    }
}
