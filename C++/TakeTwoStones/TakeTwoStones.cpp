#include<iostream>

int main(int, char**)
{
	int stones;
	std::cin >> stones;

	if (stones % 2 == 0)
	{
		std::cout << "Bob";
	}
	else
	{
		std::cout << "Alice";
	}
	return 0;
}
