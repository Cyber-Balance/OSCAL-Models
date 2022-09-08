using AutoBogus;
using Bogus;
using System;
using System.Collections.Generic;
using System.Text;
using Bogus.Extensions;

namespace Nist.Oscal.Tests.Bogus
{
    public class AddressFaker : AutoFaker<Models.Core.Address>
    {
        private const string home = "home";
        private const string work = "work";

        public AddressFaker()
        {
            RuleFor(a => a.Type, f => f.PickRandom(home, work).OrDefault(f));
            RuleFor(a => a.AddrLines, (f, u) =>
            {
                var address = new List<string>
                {
                    f.Address.StreetAddress(false)
                };

                if (f.Random.Bool())
                {
                    var secondary = f.Address.SecondaryAddress();
                    if (u.Type == work)
                    {
                        secondary = secondary.Replace("Apt.", "Suite");
                    } else if (u.Type == home)
                    {
                        secondary = secondary.Replace("Suite", "Apt.");
                    }

                    address.Add(secondary);
                }

                return address;
            });
            RuleFor(a => a.City, f => f.Address.City());
            RuleFor(a => a.State, f => f.Address.State());
            RuleFor(a => a.PostalCode, f => f.Address.ZipCode());
            RuleFor(a => a.Country, f => f.Address.CountryCode().OrDefault(f, 0.9f));

            RuleSet(BogusExtensions.OrganizationRuleSet, rules =>
            {
                RuleFor(p => p.Type, work);
            });
        }
    }
}
