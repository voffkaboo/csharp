using Bogus;
using Bogus.DataSets;

namespace WebAddressBookTests
{
    public class GroupFixtureBuilder
    {
        private readonly GroupData groupModel;

        public GroupFixtureBuilder()
        {
            this.groupModel = CreateDefaultModel();
        }
        public GroupFixtureBuilder WithName(string name)
        {
            this.groupModel.Name = name;
            return this;
        }

        public GroupFixtureBuilder WithHeader(string header)
        {
            this.groupModel.Header = header;
            return this;
        }

        public GroupFixtureBuilder WithFooter(string footer)
        {
            this.groupModel.Footer = footer;
            return this;
        }

        public GroupData Build()
        {
            return groupModel;
        }

        public GroupData CreateDefaultModel()
        {
            GroupData model = new Faker<GroupData>()
              .RuleFor(o => o.Name, f => f.Company.CompanyName())
              .RuleFor(o => o.Header, f => f.Lorem.Word())
              .RuleFor(o => o.Footer, f => f.Finance.CreditCardNumber(CardType.Visa))
              .Generate();

            return model;
        }
    }
}