using ActivityPlanner.ConsoleUI;
using Xunit;

namespace ActivityPlannerUnitTest
{
    public class InviteeUnitTest
    {
        [Fact]
        public void FullnameWithSurnamePrefix()
        {
            //arrange
            var invitee = new Invitee("Jan", "Jansen") { SurnamePrefix = "van" };
            //invitee.SurnamePrefix = "van";

            var expectedFullname = "van Jansen, Jan";
            var actualFullname = string.Empty;

            //act
            actualFullname = invitee.FullName;

            //assert
            Assert.Equal(expectedFullname, actualFullname);

        }

        [Fact]
        public void FullnameWithoutSurnamePrefix()
        {
            //arrange

            //act

            //assert


        }
    }
}