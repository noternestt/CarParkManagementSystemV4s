using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarParkManagementSystemV4.Data;
using CarParkManagementSystemV4.Domain;

public class LocationService
{
    private readonly CarParkManagementSystemV4Context _context;

    public LocationService(CarParkManagementSystemV4Context context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task<List<Location>> SearchLocationsAsync(string query)
    {
        if (string.IsNullOrWhiteSpace(query))
        {
            return await _context.Location.ToListAsync();
        }

        bool isNumeric = int.TryParse(query, out int postalCode);

        return await _context.Location
            .Where(l =>
                (isNumeric && l.PostalCode == postalCode) ||
                (!isNumeric && EF.Functions.Like(l.Address, $"%{query}%")))
            .ToListAsync();
    }
}
