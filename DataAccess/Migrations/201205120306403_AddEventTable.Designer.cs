// <auto-generated />
namespace DataAccess.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    
    public sealed partial class AddEventTable : IMigrationMetadata
    {
        string IMigrationMetadata.Id
        {
            get { return "201205120306403_AddEventTable"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return "H4sIAAAAAAAEAO1d23LbNhB970z/QcP3mI7jpE5GTsaW7dbT+NLIzTtMQjYnvJWEPNa39aGf1F8oAN4AEiABkLIoVy8ZC+SeBbGLXRA43Pz79z/TL8+BP3mCSepF4bH1dm/fmsDQiVwvfDi2lmjx5sj68vnnn6bnbvA8+V7cd0Duw5Jhemw9IhR/su3UeYQBSPcCz0miNFqgPScKbOBG9sH+/pH9dt+GGMLCWJPJ9NsyRF4A6Q/8cxaFDozREvhXkQv9NG/HV+YUdXINApjGwIHH1hlA4MRxYJpakxPfA7gHc+gvNLuz/5F0xyoVYVXnuEtodbeKIVV3bJ3490vuFnzT73DFNeCm2ySKYYJW3+CCFbx0rYnNC9t16VK2Lkh6cWxdhujdgTW5Xvo+uPdxwwL4KbQm8YdPcxQl8FcYwgQg6N4ChGCC7XLpQvoU+Wh8ij+oDchHe/+ADIgNwjBCAGEjN3pf6+udh3xY9HSOEuww1uTCe4buVxg+oMeyt1fguWh5+wG7zZ+hh/0LC6FkCQVP1672JEFeirrHiEWZ2pVt2y1OwY1MXnZL2+aKDzQKo5N/dW1+0Gbz7LeRsWbLFEUBTEzMVciaGIyV3QKTXXhJigzsdth7qn4FRopb/UVJ8SwKYhCuNPUe6fmpYCa7bkLTkpbaX/qqnVE/Gs62Kjrn2PcGdSilB43wqiF58We9jVIE/BmW1418vTU/RqH27DnsqfQCPL+0yvMAeL6m0v4riTPoQxyTC72nUeRDEGrDzJdxHCXoG4xbEkKPNHcexH60gtAkzRWyJmmOld2CNLexZGOaX/trNlmBv+sbk7CfY29P7yINX2+inHoJejxjcgj5+84LtLvzm5fAIXB2uXuXu3e5ewy5u0eqxAkoMcqTVNAkSZaCW5Ahx/Tufhk+RZ5jZKtc1MRajOgW2Et9n6EdJ3/qriyphHXq+T52nA1ly1z7JpJmrnojubN47M2k0Fz75jLpHZ4vZYY5g44XkJ+3Cf4rP7Q4siZzBxC8wXaC80nz1Qv7BCki3iNQFeJbEKyUQ2uHrRPg/OgLgr0N3SYkvQzjNE0NfyxBPrBrOIS4gq4HyG8TxyuFTdyOE94CpxvTiubWByvf8PCokDWxGSu7M5mRyWjQGdZuwtvL4LYJG1/T19H1nwqrBfAX7qeySxi7grFtew/YuCcvVtT7xL+DFKGyhtTIbO1AXS/8anthQRylMNEdSs04KBgFspRPoROFbtpvGE5XCMohVPoy9CJN/TzlCc8Xo8MUImh0klIIbsEUp309g6mTeHF2v56Pvh9gdzpBQ+zon4euPky7F82iEAH8TpYUE/nRC6PoB2mGz3WfykTmELFhDM+ZSkFGXNvLaGb1p2mIU5qQUD4jLXUBFNtJIoiSStMFUhwKikDKg8ouEBpDRQjZ/m2XeP6qKQIothUVIcj7dQsMffnvgioziwioepXrgimWeCKU8tVCFYSuKdqQsmVOF5wURk2chhKho9AILJx35Qwrr03tjAKaN0xtCVd0egXiGIcohjuat0zmGXF09mauTxINMgzbSQVc0bK3pSYcv8EDrF0lGd+F9JyYkFfvAQmaMzdo3qYUTwplXFipp69q0Ivbyd858aFk0O4JKK7s0F3gpwmwseiDwbIHQmpsLknSNUhkS7hZ5C+DsJUl24aTn3izKHmTOkbFt+Q6I+FvZj5XG476YNuN0a6tEOq2U7NsHvFNTSvgsqrZViI43IDKkLL3CxYlaxmNSaocamgUMWdVySxyUdlwsgdI7KDKya9taAzPhQVjmtWxKrIOC1W1qiOVVE/uAYtGjahQnGhxPlw0avSHLtO5ztAWdYT8iImFyJt0RiU/KuJHJW9Ux2EPfVgotl0DLaNEcEBZk4YXEoYD53+kQV0+pyuwCHmTOkZJHGRRykYNS3PMQc7g3JXRhL9q9W8Y/sRcRorQFf7konJTVwRG3t4yUmQb2nAha8hAOsSCiGH0sThMszoWw+tjsZhmdayK2sdCVa274L4L7ubBfUMhNN/7MIyfAoIbFe8KnhI52TiWm9zsSEo4cm04o1/Pl1tJhvYQ0tiULCKVlI0lQ7BgB1TKhmvDGvbFgOOXCfqmG63rHDM+kfDXtFGbIZy7oI0nCOj8Ff0eisJ7/Zo2qizYCy5rrD4yZha3+siaxjbDs53efrO8yQWjIIozXSzdMacKAphgVompZQqYg0SQ8tSas734DLwNhzkFZJGYZnWsipTFQlWto/FJ5sjA0CMlFDEK0eWPLbKykeVOz9nBbWGbteGNfl1QncYYGkjMBlOyj1xUuvRm6EHc+ruFnvQKjJMfT/W0kIDxo2UmifzL2Eo3DG/IYv0sZWohTcsMldLU58+6T8uGDttDvRZW/Kf6pn3WqvGEHKGJe0TuisZyOSM2cUvkrGm9i5pN7ehmZ/Sm27lNKhUV79zLFctJt3UK/hS3sSNmY3XicNymBiB3VWtbryAt1bb2imaNXha8Ja5zReMLe06Dl1G/pdSet5S/S15GzonoLuzVIElktxBCYPTkuYQgMV+lCAZ75Ia9+V/+zPcok6S44QqE3gLinBz9gCHlnh6Z1wgryXNp6vojLxTmkVHoJA/2KS8QPoHEeQRJs5xXz/pdtOuvp3rXWiyRLSDaDHGwP9A3EeMpqrWWkWwU6xAO56G+W9fLjwhxD/Rxa6WshLBHHcYXeC3//a4Q9RdtVPa7XIVx1a5VMRBm7TvagVCb38eKZ6o+MFtIQuxWhz3qRAyEyJWBEGIa5IpahaZ7rytVCBxIUJ2plnJeRW2mtUTLdQU1tShsANy9ZHmnPf8aBY863aeJ0Sh35OK/0QDljkxxdglglwA2mwC2uczPti/yR1J9Zy3DKHmR6F8zRxRqe9TMGSjkCkriDBTPRBVvhoVeTxyW1qsZKBxz5Wjc/285mrXMXnGM6FdExgSi8XVyT0M3NdRLyAy4DzaqAjLbnivHU9fltYzkFpZbeZEotD1FSjbjibSUSL/aIQav7rKQ1q9uiEFH6lVDxGPUNVsFDygoCmLyhFxJEIPnGzrlbk9BkLVMJ1khD7HbvDfZmOHrdJhuRdXqdKjBaNbpaHx+z/eoPADnznOllTqyc2nc1XuyJ5h1UaeIR0sNDyG0Xn2P1vIeInzt4h+ttT9EGvQqg8gLg4iwtWqGtJUMEYEb1BPpKifSokav3kh7uRGRGv1qJK3FSEQqzEqVdFcqadOlUcxEXstEpECjzIm8yolwPuSVUUQRTaECSpNRM7XZ/1BvisO+91BBkP9eL4QOyQIVaHHPZbiIioiMH4rtUXFLY0WEgEtIYDguLYCDk3ZE2GC0PNR34C/phL+H7mV4s0TxEp2kKQzufY6BP7Xb9dMyL3yfpzc0j6VDPALupkcSzU14uvR8t+z3hWAZIYEgOSVP17hXc0TS9sOqRLpufPooA8qH7wzGMCTJ/g7iaInB0ptwDp6gvG/dY8iP2PTMAw8JCNgRzFqKlA6wZkYFVsBKVPrwT+yubvD8+T/SFvoEQnIAAA=="; }
        }
    }
}