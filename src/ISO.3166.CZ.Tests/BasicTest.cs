using Xunit;

namespace ISO3166CZ.Tests
{
	public class BasicTest
	{
		[Fact]
		public void TestEnum()
		{
			Assert.NotEmpty(Alpha2Country.FR.GetName());
			Assert.NotEmpty(Alpha3Country.CZE.GetName());
			Assert.True(Alpha2Country.CZ > 0);
			Assert.True(Alpha3Country.CZE > 0);
			Assert.Equal((int)Alpha2Country.CZ, (int)Alpha3Country.CZE);
		}

		[Fact]
		public void TestCountry()
		{
			var all = Country.GetCountries();
			Assert.NotNull(all);
			Assert.NotEmpty(all);
			Assert.Contains(all, x => x.Numeric == (int)Alpha2Country.CZ);
			Assert.Contains(all, x => x.Alpha2 == Alpha2Country.CZ);
			Assert.Contains(all, x => x.Alpha3 == Alpha3Country.CZE);
			Assert.Contains(all, x => x.Name == Alpha3Country.CZE.GetName());
		}
	}
}
