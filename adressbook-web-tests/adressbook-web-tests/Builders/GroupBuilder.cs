namespace WebAddressBookTests
{
    public class GroupBuilder
    {
        private readonly GroupFixtureBuilder groupFixtureBuilder;
        private readonly AppManager manager;

        public GroupBuilder(AppManager manager)
        {
            this.groupFixtureBuilder = GroupFixtureBuilder.CreateNew();
            this.manager = manager;
        }

        public GroupBuilder WithName(string name)
        {
            this.groupFixtureBuilder.WithName(name);
            return this;
        }

        public GroupBuilder WithHeader(string header)
        {
            this.groupFixtureBuilder.WithHeader(header);
            return this;
        }

        public GroupBuilder WithFooter(string footer)
        {
            this.groupFixtureBuilder.WithFooter(footer);
            return this;
        }

        public void Build()
        {
            var createGroupFixture = this.groupFixtureBuilder.Build();
            this.manager.Groups.Create(createGroupFixture);
        }
    }
}