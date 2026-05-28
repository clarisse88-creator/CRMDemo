namespace MauiApp1.Pages;
using MauiApp1.Models;

public partial class Users : ContentPage
{
	

	public Users()
	{
		InitializeComponent();
		
		LoadUsers();
	}

	private List<User> users = new List<User>
	{
			new User { Id = 1, Name = "Alice", Email = "alice@example.com" },
			new User { Id = 2, Name = "Bob", Email = "bob@example.com" },
			new User { Id = 3, Name = "Charlie", Email = "charlie@example.com" },
		
	};
	// public UserPage()
	// {
		
	// 	LoadUsers();
		
	// }
	private void LoadUsers()
	{
		UsersCollectionView.ItemsSource = users;
	}

	  private async void OnUserSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is User selectedUser)
        {
            // Navigate to the UserDetails page, passing the selected user's ID as a query parameter
            await Shell.Current.GoToAsync($"user-details?Id={selectedUser.Id}");
        }
	}
}
