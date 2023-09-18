using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IBlogService
	{
		void BlogAdd(Category category);

		void BlogRemove(Category category);

		void BlogUpdate(Category category);

		List<Blog> GetList();

		Blog GetBYID(int id);
	}
}
