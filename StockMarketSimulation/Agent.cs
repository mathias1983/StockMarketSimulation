using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarketSimulation
{
    public interface Agent
    {
        List<float> getBudgetHistory();
        float getBudget();
        int getAgentNumber();
        Dictionary<int, int> getStockInventory();
        Order act(Stock currentStock);
        Order actBeforeOpening(Stock currentStock);

    }
}
