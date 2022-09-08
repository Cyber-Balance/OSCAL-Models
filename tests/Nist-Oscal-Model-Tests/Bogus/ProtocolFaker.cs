using AutoBogus;
using Bogus;
using Bogus.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Nist.Oscal.Tests.Bogus
{
    public class ProtocolFaker : AutoFaker<Models.Core.Protocol>
    {
        public ProtocolFaker()
        {
            RuleFor(p => p.Uuid, f => f.Random.UuidV4().OrNull(f, 0.5f));
            RuleFor(p => p.Name, f => f.Internet.Protocol());
            RuleFor(p => p.Title, f => f.Lorem.Title().OrDefault(f, 0.5f));
            RuleFor(p => p.PortRanges, f =>
            {
                int count = f.Random.Int(1, 5);
                var ranges = new List<Models.Core.PortRange>(count);
                var ports = f.Make(count * 2, () => f.Internet.Port()).OrderBy(p => p).ToArray();
                for (int i = 0; i < count; i++)
                {
                    ranges.Add(new Models.Core.PortRange
                    {
                        Transport = f.PickRandomParam("TCP", "UDP"),
                        Start = ports[(i * 2)],
                        End = ports[(i * 2) + 1]
                    });
                }

                return ranges.OrEmptyList(f, 0.25f);
            });
        }
    }
}