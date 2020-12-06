// MathLibrary.cpp : Defines the exported functions for the DLL.
#include "pch.h" // use stdafx.h in Visual Studio 2017 and earlier
#include <utility>
#include <limits.h>
#include "Calc.h"

extern "C" __declspec(dllexport) int add(int a, int b)
{
	return a + b;
}

extern "C" __declspec(dllexport) int sub(int a, int b)
{
	return a - b;
}

extern "C" __declspec(dllexport) int mult(int a, int b)
{
	return a * b;
}

extern "C" __declspec(dllexport) int div2(int a, int b)
{
	if (b == 0)
	{
		throw;
	}
	return a / b;
}