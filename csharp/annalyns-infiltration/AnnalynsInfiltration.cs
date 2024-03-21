using System;
static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if (!knightIsAwake && !archerIsAwake && !prisonerIsAwake)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) => prisonerIsAwake && !archerIsAwake;

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if (archerIsAwake) {
            return false;
        }
        else if (knightIsAwake && !petDogIsPresent) {
            return false;
        }
        else if (knightIsAwake && prisonerIsAwake && !petDogIsPresent)
        {
            return false;
        }
        else if (!knightIsAwake && !archerIsAwake && !prisonerIsAwake && !petDogIsPresent)
        {
            return false;
        }
        else return true;
    }
}
