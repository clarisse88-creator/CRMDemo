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