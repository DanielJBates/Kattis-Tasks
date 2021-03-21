#include<iostream>
#include<string>

int main(int, char**)
{
	std::string greeting;
	std::cin >> greeting;

	int count = 0;

	for (int i = 0; i < greeting.length(); i++)
	{
		if (greeting[i] == 'e')
		{
			count++;
		}
	}

	std::string response = "h";

	for(int i = 0; i < count * 2; i++)
	{
		response += 'e';
	}
	response += 'y';

	std::cout << response;

	return 0;
}