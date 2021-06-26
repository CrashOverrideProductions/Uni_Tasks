/******************************************************************************
 AUTHOR:         JUSTIN BLAND
 TASK:           8-1C (MyTime.java)
 DATE:           11/09/2020
 STATUS:         COMPLETED

 REVISIONS:      11/09/2020 - FILE CREATION
 ******************************************************************************/
package com.company;

public class MyTime {
    // Instance Variables
    private int _hour;
    private int _minute;
    private int _second;

    public int getterHour ()
    {
       return _hour;
    }

    public void setterHour(int  hour)
    {
        if (hour < 0 || hour > 23)
        {
            throw new IllegalArgumentException("Invalid Hour - Hour needs to be Between 00 and 23");
        }
        this._hour = hour;
    }

    public int getterMinute ()
    {
        return _minute;
    }

    public void setterMinute(int  minute)
    {
        if (minute < 0 || minute > 59)
        {
            throw new IllegalArgumentException("Invalid Minute - Minute needs to be Between 00 and 59");
        }
        this._minute = minute;
    }

    public int getterSecond ()
    {
        return _second;
    }

    public void setterSecond(int  second)
    {
        if (second < 0 || second > 59)
        {
            throw new IllegalArgumentException("Invalid Second - Second needs to be Between 00 and 59");
        }
        this._second = second;
    }

    // Constructor
    public MyTime(){}

    public MyTime(int hour, int minute, int second)
    {
        setterHour(hour);
        setterMinute(minute);
        setterSecond(second);
    }

    public void SetTime(int hour, int minute, int second)
    {
        setterHour(hour);
        setterMinute(minute);
        setterSecond(second);
    }

    // Methods

    public void SetHour(int hour)
    {
        setterHour(hour);
    }

    public void SetMinute(int minute)
    {
        setterMinute(minute);
    }

    public void SetSeconds(int second)
    {
        setterSecond(second);
    }

    public int GetHour()
    {
        return getterHour();
    }


    public int GetMinute()
    {
        return getterMinute();
    }

    public int GetSecond()
    {
        return getterSecond();
    }

    String LeftPad(int num)
    {
        if (num <= 9)
        {
            String temp = Integer.toString (num);
            temp = "0" + temp;
            return temp;
        }
        else
        {
            return Integer.toString (num);
        }
    }

    public String ToString()
    {
        return LeftPad(getterHour()) + ":" + LeftPad(getterMinute()) + ":" + LeftPad(getterSecond());
    }

    public MyTime NextSecond()
    {
        try
        {
            setterSecond(getterSecond() + 1);
        }
        catch (IllegalArgumentException exception)
        {
            setterSecond(0);
            NextMinute();
        }
        return this;
    }

    public MyTime NextMinute()
    {
        try
        {
            setterMinute(getterMinute() + 1);
        }
        catch (IllegalArgumentException exception)
        {
            setterMinute(0);
            NextHour();
        }
        return this;
    }

    public MyTime NextHour()
    {
        try
        {
            setterHour(getterHour() + 1);
        }
        catch (IllegalArgumentException exception)
        {
            setterHour(0);
            //NextDay();
        }
        return this;
    }

    public MyTime PreviousSecond()
    {
        try
        {
            setterSecond(getterSecond() - 1);
        }
        catch (IllegalArgumentException exception)
        {
            setterSecond(59);
            PreviousMinute();
        }
        return this;
    }

    public MyTime PreviousMinute()
    {
        try
        {
            setterMinute((getterMinute() - 1));
        }
        catch (IllegalArgumentException exception)
        {
            setterMinute(59);
            PreviousHour();
        }
        return this;
    }

    public MyTime PreviousHour()
    {
        try
        {
            setterHour(getterHour() - 1);
        }
        catch (IllegalArgumentException exception)
        {
            setterHour(23);
            //PreviousDay();
        }
        return this;
    }

}
