int GetArrea (int x, int y)
{
    int NumArr = 0;

    if (x > 0 && y > 0) NumArr = 1;
    else if (x > 0 && y < 0) NumArr = 4;
    else if (x < 0 && y > 0) NumArr = 2;
    else if (x < 0 && y < 0) NumArr = 3; 
    return NumArr;
}



//Свитчкейс





int a = GetArrea(6, 9); 