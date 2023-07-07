// Дан текст. Нужно в нем заменить все пробелы на |, "," на ;

string text = "Для вас, души моей царицы, "
    + "Красавицы, для вас одних"
    + "Времен минувших небылицы,"
    + "В часы досугов золотых,"
    + "Под шепот старины болтливой,"
    + "Рукою верной я писал;"
    + "Примите ж вы мой труд игривый!"
    + "Ничьих не требуя похвал,"
    + "Счастлив уж я надеждой сладкой,"
    + "Что дева с трепетом любви"
    + "Посмотрит, может быть, украдкой"
    + "На песни грешные мои.";

    string Replace (string inText, char oldValue, char newValue)
    {
        string Result = string.Empty;
        int length = inText.Length;
        for (int i = 0; i < length; i++)
        {
            if (inText[i] == oldValue) Result += $"{newValue}";
            else Result += $"{inText[i]}";
        }

        return Result;
    }

char a = Convert.ToChar(" ");
char b = Convert.ToChar("|");
string TextNew = Replace (text, a, b);
Console.WriteLine(TextNew);