#pragma once
#include<iostream>
#include"Num.h"
using namespace std;

//要求用户输入答案并与结果比较
int judge(num res);

//判断答案格式
int Check(char * ans);

//将答案字符串转为数字
int turn2num(char * ans, int *ansnum);