CrmDemo  support ticket deleted for mudblazor is for all page before mud blazor
   @* <table class="table">
        <thead>
            <tr>
            <th>Id</th>
            <th>CustomerId</th>
            <th>Subject</th>
            <th>Description</th>
            <th>Status</th>
            <th>CreatedAt</th>
            <th>CreatedBy</th>
            <th>Priority</th>
            <th>Type</th>
            <th>ClosedAt</th>
            <th>Action</th>
            </tr>
        </thead>
    @foreach (var Ticket in _supportTicket)

    {
          <tr>
            <td>@Ticket.Id</td>
            <td>@Ticket.CustomerId</td>
            <td>@Ticket.Subject</td>
            <td>@Ticket.Description</td>
            <td>@Ticket.Status</td>
            <td>@Ticket.CreatedAt</td>
            <td>@Ticket.CreatedBy</td>
            <td>@Ticket.Priority</td>
            <td>@Ticket.Type</td>
            <td>@Ticket.closedAt</td> *@
             
                  @* <a href="/SupportTicket/@Ticket.Id" class="btn btn-primary">Details</a>
                  <a href="/SupportTicket/Edit/@Ticket.Id" class="btn btn-primary">Edit</a> *@
                  @* <MudTd DataLabel="Actions" Style="text-align:center">
                    <MudStack Row="true" Spacing="2" Justify="Justify.Center">
             <MudButton Href="@string.Format("/SupportTicket/Edit/{0}", Ticket.Id)" 
                                   Variant="Variant.Filled" 
                                   Color="Color.Warning" 
                                   Size="Size.Small"
                                   StartIcon="@Icons.Material.Filled.Edit">
                            Edit
                        </MudButton>
             <MudButton Href="@string.Format("/SupportTicket/{0}", Ticket.Id)" 
                                   Variant="Variant.Filled" 
                                   Color="Color.Primary" 
                                   Size="Size.Small"
                                   StartIcon="@Icons.Material.Filled.MoreHoriz">
                            View
                        </MudButton>
                       </MudStack>
                </MudTd>
            </td>
             </tr>
    }
    </table>
     </MudStack>
     </MudPaper> 

    *************************** home page******************

    @page "/"

<PageTitle>Home</PageTitle>

<h1>Hello, world!</h1>

Welcome to your new app.

@**************User using boostrap before mudblazor********************* 
<table class="table">
    <thead>
        <tr>
            <th>Id</th>
            <th>FirstName</th>
            <th>LastName</th>
            <th>Email</th>
            <th>PhoneNumber</th>
            <th>Password</th>
            <th>Role</th>
            <th>Status</th>

            
        </tr>
    </thead>
    @foreach (var User in users)

    {
        <tr>
            <td>@User.Id</td>
            <td>@User.FirstName</td>
            <td>@User.LastName</td>
            <td>@User.Email</td>
            <td>@User.PhoneNumber</td>
            <td>@User.Password</td>
            <td>@User.Role</td>
            
            

            <td>
            <a href="/Users/@User.Id" class="btn btn-primary">Details</a>
            <a href="/Users/edit/@User.Id" class="btn btn-primary">Edit</a> *@
             <MudTd DataLabel="Actions" Style="text-align:center">
                    <MudStack Row="true" Spacing="2" Justify="Justify.Center">
             <MudButton Href="@string.Format("/Users/Edit/{0}", User.Id)" 
                                   Variant="Variant.Filled" 
                                   Color="Color.Warning" 
                                   Size="Size.Small"
                                   StartIcon="@Icons.Material.Filled.Edit">
                            Edit
                        </MudButton>
             <MudButton Href="@string.Format("/Users/{0}", User.Id)" 
                                   Variant="Variant.Filled" 
                                   Color="Color.Primary" 
                                   Size="Size.Small"
                                   StartIcon="@Icons.Material.Filled.MoreHoriz">
                            View
                        </MudButton>
                       </MudStack>
                </MudTd>
            </td>
        </tr>
    }
    </table> *@ *@

   *************************Authontication for security purpose**********************
  entity core  infrastructure auth
   entity frame work core linking database
   identity UI
            #####
   Infrastructure identity folder

   extend into APPdbcontext
   using identity table remover old user crate user identity

   

   **********************
     <div class="container mt-4">
        <div class="row justify-content-center">

        <EditForm Model="@Model" OnValidSubmit="OnValidSubmit">
            <DataAnnotationsValidator />
            <ValidationSummary  class="alert alert-danger py-2 mb-3"/>
<div class="row g-2 mb-2"> 
       <div class="col-md-6 ">
            <label for="Name" class="form-label"> Name</label>
            <InputText id="Name" class="form-control" @bind-Value="Model.Name" placeholder="Enter Name" />
            <ValidationMessage For="@(() => Model.Name)" class="text-danger"/>
       </div>
       <div class="col-md-6 ">
            <label for="Description" class="form-label"> Description</label>
            <InputText id="Description" class="form-control" @bind-Value="Model.Description" placeholder="Enter Description" />
            <ValidationMessage For="@(() => Model.Description)" class="text-danger"/>
       </div>
       @* <div class="col-md-6 ">
            <label for="Type" class="form-label"> Type</label>
            <InputText id="Type" class="form-control" @bind-Value="Model.Type" placeholder="Enter Type" />
            <ValidationMessage For="@(() => Model.Type)" class="text-danger"/>
      
         *@
        <div class="col-md-6 ">
            <label for="Budget" class="form-label"> Budget</label>
            <InputText id="Budget" class="form-control" @bind-Value="Model.Budget" placeholder="Enter Budget" />
            <ValidationMessage For="@(() => Model.Budget)" class="text-danger"/>
       </div>
        <div class="col-md-6 ">
            <label for="Status" class="form-label"> Status</label>
            <InputText id="Status" class="form-control" @bind-Value="Model.Status" placeholder="Enter Status" />
            <ValidationMessage For="@(() => Model.Status)" class="text-danger"/>
       </div>
            <div class="col-md-6 ">
            <label for="StartDate" class="form-label">StartDate</label>
            <InputDate id="StartDate" class="form-control" @bind-Value="Model.StartDate" placeholder="Enter StartDate" />
            <ValidationMessage For="@(() => Model.StartDate)" class="text-danger"/>
       </div> 
       <div class="col-md-6 ">
            <label for="EndDate" class="form-label"> EndDate</label>
            <InputDate id="EndDate" class="form-control" @bind-Value="Model.EndDate" placeholder="Enter EndDate" />
            <ValidationMessage For="@(() => Model.EndDate)" class="text-danger"/>
       </div>   
            <div>
            <button type="submit" class="btn btn-primary mt-3">Edit Campaign</button>
            @* <a href="/Campaigns" class="btn btn-link btn text-muted">Cancel</a> *@
            <MudButton Href="@string.Format("/Campaigns")" Variant="Variant.Text" Color="Color.Secondary" StartIcon="@Icons.Material.Filled.Cancel">Cancel</MudButton>
            @* <MudButton Type="Submit" Variant="Variant.Filled" OnClick="Campaigns" Color="Color.Primary" StartIcon="@Icons.Material.Filled.Edit">Edit Campaign</MudButton> *@
          



