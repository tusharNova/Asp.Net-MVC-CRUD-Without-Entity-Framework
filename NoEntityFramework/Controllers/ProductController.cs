using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using NoEntityFramework.Models;
using System.Data.SqlTypes;

namespace NoEntityFramework.Controllers
{
	public class ProductController : Controller
	{
		// GET: ProductController
		string ConnectionString = "Server=DESKTOP-UAD5JOD;Database=MvcCurdDb;Trusted_Connection=True;MultipleActiveResultSets=True;Encrypt=False";
		[HttpGet]
		public ActionResult Index()
		{
			DataTable dt = new DataTable();
			using (SqlConnection sqlConn = new SqlConnection(ConnectionString))
			{
				sqlConn.Open();
				SqlDataAdapter sqlDa = new SqlDataAdapter("select * from Product", sqlConn);
				sqlDa.Fill(dt);
			}
			return View(dt);
		}

		// GET: ProductController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: ProductController/Create
		public ActionResult Create()
		{
			return View(new ProductModel());
		}

		// POST: ProductController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(ProductModel productModel)
		{
			using (SqlConnection sqlConn = new SqlConnection(ConnectionString))
			{
				sqlConn.Open();
				string query = "INSERT into Product VALUES (@ProductName ,@Price ,@Count)";
				SqlCommand cmd = new SqlCommand(query, sqlConn);
				cmd.Parameters.AddWithValue("@ProductName", productModel.ProductName);
				cmd.Parameters.AddWithValue("@Price", productModel.Price);
				cmd.Parameters.AddWithValue("@Count", productModel.Count);
				cmd.ExecuteNonQuery();

			}

			return RedirectToAction("Index");
		}

		// GET: ProductController/Edit/5
		public ActionResult Edit(int id)
		{
			ProductModel productmodel = new ProductModel();
			DataTable dt = new DataTable();
			using (SqlConnection sqlConn = new SqlConnection(ConnectionString)) 
			{
				sqlConn.Open();
				string query = "Select * from Product where ProductId = @ProductId";
				SqlDataAdapter sqlDa = new(query ,sqlConn);
				sqlDa.SelectCommand.Parameters.AddWithValue("@ProductId" , id);
				sqlDa.Fill(dt);
			}
            if (dt.Rows.Count == 1)
            {
				productmodel.ProductId = Convert.ToInt32(dt.Rows[0][0].ToString());
				productmodel.ProductName = dt.Rows[0][1].ToString();
				productmodel.Price = Convert.ToDecimal(dt.Rows[0][2].ToString());
				productmodel.Count = Convert.ToInt32(dt.Rows[0][3].ToString());
				return View(productmodel);

			}
			else
				return RedirectToAction("Index");
        }
		 
		// POST: ProductController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(ProductModel productModel)
		{
			using (SqlConnection sqlConn = new SqlConnection(ConnectionString))
			{
				sqlConn.Open();
				string query = "UPDATE Product SET ProductName = @ProductName , Price = @Price ,Count = @Count WHERE ProductId = @ProductId";
				SqlCommand cmd = new SqlCommand(query, sqlConn);
				cmd.Parameters.AddWithValue("@ProductId", productModel.ProductId);
				cmd.Parameters.AddWithValue("@ProductName", productModel.ProductName);
				cmd.Parameters.AddWithValue("@Price", productModel.Price);
				cmd.Parameters.AddWithValue("@Count", productModel.Count);
				cmd.ExecuteNonQuery();

			}

			return RedirectToAction("Index");
		}

		// GET: ProductController/Delete/5
		public ActionResult Delete(int id)
		{
			using (SqlConnection sqlConn = new SqlConnection(ConnectionString))
			{
				sqlConn.Open();
				string query = "DELETE from Product WHERE ProductId = @ProductId";
				SqlCommand cmd = new SqlCommand(query, sqlConn);
				cmd.Parameters.AddWithValue("@ProductId", id);
				
				cmd.ExecuteNonQuery();

			}

			return RedirectToAction("Index");
		}

		// POST: ProductController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
