using System;

public interface ICurrencyVaultState
    {
        int CurrentCount { get; }

        event Action<int> OnChange;
    }