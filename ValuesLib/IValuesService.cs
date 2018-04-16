namespace Nettolicious.ValuesLib
{
	public interface IValuesService
	{
		string[] Get();
		string Get(int id);
	}
}