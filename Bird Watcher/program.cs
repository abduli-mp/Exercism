class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] counts = { 0, 2, 5, 3, 7, 8, 4 };

        return counts;

    }

    public int Today()
    {
        return birdsPerDay.Last();
    }

    public void IncrementTodaysCount()
    {
        int LastDay = birdsPerDay.Last();
        LastDay  = LastDay + 1;
        birdsPerDay[birdsPerDay.Length - 1] = LastDay;
    }

    public bool HasDayWithoutBirds()
    {
        return Array.IndexOf(birdsPerDay, 0) != -1;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int TotalEl = 0;
        
        for(int bird = 0; bird < numberOfDays; bird++)
        {
            TotalEl += birdsPerDay[bird];
        }


        return TotalEl;
    }

    public int BusyDays()
    {
        int count = 0;

        foreach (int bird in birdsPerDay)
        {
            if (bird >= 5)
            {
                count++;
            }
        }

        return count;
    }
}