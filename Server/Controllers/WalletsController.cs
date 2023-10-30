using Endava.TechCourse.BankApp.Domain.Models;
using Endava.TechCourse.BankApp.Infrastructure.Persistence;
using Endava.TechCourse.BankApp.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Endava.TechCourse.BankApp.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WalletsController : ControllerBase
	{
		private readonly ApplicationDbContext _dbContext;

		public WalletsController(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		[HttpPost]
		public IActionResult CreateWallet([FromBody] CreateWalletDTO createWalletDTO)
		{
			var wallet = new Wallet
			{
				Type = createWalletDTO.Type,
				Amount = createWalletDTO.Amount,
				Currency = new Currency
				{
					Name = "Euro",
					CurrencyCode = "EUR",
					ChangeRate = 20
				}
			};

			_dbContext.Wallets.Add(wallet);
			_dbContext.SaveChanges();

			return Ok();
		}

		[HttpGet]
		public IActionResult GetWallets()
		{
			var walletsDomain = _dbContext.Wallets.ToList();

			var walletsDTO = new List<GetWalletDTO>(walletsDomain.Count);

			foreach (var walletDomain in walletsDomain)
			{
				var walletDTO = new GetWalletDTO
				{
					Id = walletDomain.Id,
					CreateDate = walletDomain.TimeStamp,
					Type = walletDomain.Type,
					Amount = walletDomain.Amount
				};

				walletsDTO.Add(walletDTO);
			}

			return Ok(walletsDTO);
		}
	}
}
