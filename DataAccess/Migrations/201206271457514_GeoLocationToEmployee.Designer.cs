// <auto-generated />
namespace DataAccess.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    
    public sealed partial class GeoLocationToEmployee : IMigrationMetadata
    {
        string IMigrationMetadata.Id
        {
            get { return "201206271457514_GeoLocationToEmployee"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return "H4sIAAAAAAAEAO1dzXLbNhC+d6bvoNE9puM4rZuR27Flu/XUTtzI7R0mYYkTkmBJyGM9Ww99pL5CAf4CJEACIGjJiS4ZE+R+AHaBXfysvvz3z7+zX57DYPIEk9RH0en07cHhdAIjF3l+tDydrvHjm5PpLz9//93s0gufJ3+V372j3xHJKD2drjCOPzhO6q5gCNKD0HcTlKJHfOCi0AEeco4OD39y3r51IIGYEqzJZPZ5HWE/hNkDeZyjyIUxXoPgFnkwSIty8maRoU4+ghCmMXDh6fQCYHDmujBNp5OzwAekBQsYPE4n8fGHP1O4wAmKlosYYB8E95sYkvePIEhh0d4P8bFqkw+PaJMdEEUIEzgUGXV5WnWGdOeSdBtvaLOyLp1Oz4KHNfcJ+eh3uOEKSNFdgmKY4M1n+MgKXnvTicMLO03pSrYpSFtxOr2O8Luj6eTjOgjAQwArZRFtLjBK4K8wggnA0LsDGMOE2P7ag1kvWlU3Krr3cQDLaohZyIiaTq78Z+jdwGiJV1VVt+C5LHn7AxlXf0Y+GYBECCdrKGhad7VnCfZT3N9BFmXm1IbpNlcGbmSvqlnaBlPs0HCL0X91DXbUZbD82UjT83WKUQgTE12XsibaZmXH1veVn6TYQOnHgyfJDTCquNPYShXPURiDaKNZ74neIBPMIc9LsoihVe2PQ6udZ4PAnm1V6lyQWGV1QCl1FJGAnrx4X+9QikEwJ/K6bmtwzSsUac+e44GVXoHnl67yMgR+oFnp8Bh+AQNIHGpZ7zlCAQSRNsxiHccowZ9h3OHNVbTwK0Q3yC0hyNMyAfFqowtzQ1amPl4zo5WoM9C2yQ1ZjOqiKMfdyzAO0AZCk7hbyprEXVZ27Li7tehnGvCH12yyGH831EmSiUemX3qPBk2+cz/BqwsmqNG/7/1Quzm/+Qm0gbNfTOwXE/vFxC4sJvaxm4vdJCImRoE7EzSJ2pXgt3Q0cR09Id81UnQhaqJqRnRsZauf"
                       + "gXTjFE3ui7lKWOd+EBCrbyn2FrVvIwQXVW8lEpfd3k5ALmrfXly+R6TiauRC1w/p411C/iquS06mk4ULKJ61I+Zi0tz40RAPQ8UHeJlSfGxPo+zUegyVAPfLUBAyVPBdQh27HYu3a/hjDQqtjHA1cQs9H9Bnk1FTCZuMGU74W1oI3AVgExjeB5WyJgpnZb9FfWfT3a7ShZ9XbmUbBvqY7Qmt+D2dSpSNYWwEY60O7u2IY/7ocPjFdc/FvMqKRcMV9+2auzd2auc4YYxSmOiqUtN9CLRAF44pdFHkpcPUcL7BUA6h0hbbqwr1g/wnMtiNTvGpoNERfik49vzMKrqAqZv4cZ6XozfA3ls4Fk2wlW3tZeRZwTkLggtQLSzVLsy6h9IcRRiQbUBSzuaVHyH0hRbD5+bAykUWELO+jEycuoI8S+sgz3dqdqYlnqW8COXzBJw+gPIEQwRRZZb0gZRXUiKQ6pqsDyRzpCKE/LCuT7zYIIkAymMoRQi6peuAyfabfVBVeBEB1RuQPphyeSRCqdbUqiDZqqALKV+o9MFJYdTEM5ckHCiZGxbOu2qGVe9mTp7vWBTMHEli5OwWxDFxdUyiZFEyWeRZkvM3C/1sxTDHcNxUkLRYtbaqiThxsISNtzTsezC76KSZmg+Aep25F7Y/U/InZWWcW2nGsFrp5ef07yKVoEoXPRDkWrKquyK9CYmxso7BqgXCHM1CksZskMjWcXMUrMOoM12zC6e4smVRiiJ1jDp3kGuMJBcxH3MNdTSV7bS03VgmNG2nZtnC45uaVpCXqWZbiaA9hcqQ8k0Gi5KX7IxJ6hhqaBRxCqeSWeSiMnWydxasUuW5oF1oTKIGC8YUq2PV2SYsVF2qjlQlT3IdLAs1vEJ5icKN4bJQoz3ZWp1rjGD13oVQ3GqwEEWRjlaK2wleK0WhOg57z8BCseUaaPmdPge0EhzpdI5CekXPjT9aoC5f3LezCEWROkaViseiVIUaluZy8TiD"
                       + "c2/UEcuLfRarLNOYnfW9Pjc962KdmY5FUFXpzrj2emdj6NrFWYIZQp9rl4vKh3GdGsiPZVm6YbeRbLljm0HCxmKPSbdjcZhidSwm6Y7FYorVseq8OxaqLt0Hrn3gsh+49uHBODwUZ1aGsUGQhZaJ9wUGiZzcvsUNBW9gYSJbF87O78OqI0BDewjT1ZQsIpWU6ZJJ52AVKs1668Kyu6HjUtEEbdONRM10ND5I8u+0UdvhiXuhjScIVvwb/RaKQlfznTaqLJAJXmusrPIkLm5llRft2gzPT+iHzfJ22lgGojjTxdI9c6rMFRPMKnEWmgKmFQ9S5QtwthdnH3ThMFe4LBJTrI5Vp4CxUHXpzoxJ5qrHcERKEtIyiL7x2CEr0yyX+sAqtyO3rQtv59cF9S2aoYHE6WtK9pGLSrcVTEoUt7foSMn6CoxTXCsOtJAg10rLTBL5l7GVrhveksWGWcrUQpqWsRXS1OfP2Lectt22rW1hnbzWvGzJSzV6yGWjcV3k3mgsl/OsNG6JnBeNu6jZ1ml1nlthelTdzoPLxHvPqcVy0iOrMvmNO7QSp9L14nC5bS1A7q3WkWWZtNY4tiyLNVpZpq1xjSsLdbxInrbGO5G87IXHXysrp/lJVXtRUj1XWTlFRkw/h1krRSb/hOaEoiffo+kxi02KYXhAPzhY/B3MAz/LIyo/uAWR/whJZEdfYJSlH5806NAMqMqcNPWCHecr86kWevNHh7AjRE8gcVcgaROTDWQiy5r+9fCQjWKJfBnSZYijQ0u/JtkdhrFRNNniGhGq81h/WDfZU4S4R/q4DWowIexJj/EFo5b/wbAQ9UdtVPaHwAp61abasITZ+OGuJdT2D3LFM1UfmOXBEA+r4wE0F5YQORYLIaZBrGgwXj34faFCMIAEbFeNkKPPl7G0xpeRQHrmPowtox/jFfJcjeL9x3LSalHFALh/CfZO25+0+KcMpkOLfcojf2ML7FOmOPuAtg9o2w1o+yiy"
                       + "O4xLr30TtiNcSqOoUbLRG06iJAodA0iULIUQAUeSJf8sokCyCz1OXJESGFkKLxw/kfft8hONMnvFPmIYMZEJRItAYKCh2zU0aYksnlPuFCnRa4+Vu0M39LVo8hUSCb2IF3o9JEDbGYkZ288weh+DowiZSxtG7WPQkCaxj1hHfbNV0EEBb49JDznWHoP+2Q65r4ezZ5TpJKPrEQ+b9yYHTTwbj/H+qMHGY4zDs/H0H+ZrMvG0CDb4xlRJDtydvZSLJ889IL19oOekeRt1aHo6WHqE0HoMPp0EPiJ8bXqfTnYfUQ163D9y6h8RthYrUBcpkAjcgDGojzCooxo9RqFuQiFRNfp8Q510Q6IqzMiI+rmIuurSoCuSsxWJKtAgMpLzGAnnQ8F9JPJoChxH7aypmcP+/5AzEjr8ZQ1B/7fICLo0ktSg5TfX0SMqnTHpFNui8pPWqgoDj6YLEr/0CFwS+BHNG8yI5P4CwTqb8A/Qu44+rXG8xmdpCsOHgEtQmznd9WdETnybZ5+yWJja6AJppk9j1afofO0HXtXuK0GkkUDQmFKEfNKqBaahf7mpkAQ8oRKgQn0XMIYRXTDcQ+ItCVj6KVqAJyhvW78OeY3NLnywTECYFhi1PHkkw88Ln3/+H6A3/PPhdAAA"; }
        }
    }
}