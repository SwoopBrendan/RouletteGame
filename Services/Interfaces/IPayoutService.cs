﻿using DerivcoAssessment.Enums;
using DerivcoAssessment.Models;

namespace DerivcoAssessment.Services.Interfaces
{
    public interface IPayoutService : IBaseService<Payout>
    {
        Task<List<Payout>> CalculateBetPayouts(Spin spin, List<Bet> placedBets);
        double CalculateBetResult(BetColour spinColour, BetColour betColour, double amount);

    }
}