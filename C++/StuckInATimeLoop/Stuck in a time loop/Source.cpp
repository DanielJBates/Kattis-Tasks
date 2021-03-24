#include<iostream>
int main(int, char**)
{
	int loops;
	std::cin >> loops;

	for (int i = 0; i < loops; i++)
	{
		std::cout << i + 1 << " Abracadabra" << std::endl;
	}

	return 0;
}