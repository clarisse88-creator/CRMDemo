// <MudContainer MaxWidth="MaxWidth.Large" Class="py-8">
//     <MudPaper Elevation="0" Class="mb-6">
      
//         <MudStack Row="true" Spacing="3" AlignItems="AlignItems.Center" Class="p-6">
//             <MudText Typo="Typo.h4" GutterBottom="false">Campaign Page</MudText>
//             <MudSpacer />
//                 <MudButton Variant="Variant.Filled" Color="Color.Primary" OnClick="@(()=>OpenDialog())">Add Customer</MudButton>

        
//         </MudStack>
//     </MudPaper>

//     <MudPaper Elevation="1">
//         <MudTable Items="@campaigns" 
//                   Hover="true" 
//                   Bordered="true" 
//                   Striped="true"
//                   Dense="false"
//                   CanCancelEdit="true"
//                   Class="mud-elevation-1">
                  
//             <HeaderContent>
//                 <MudTh>
//                     <MudTableSortLabel SortBy="new Func<Campaign, object>(x=>x.Id as object)">Id</MudTableSortLabel>
//                 </MudTh>
//                 <MudTh>
//                     <MudTableSortLabel SortBy="new Func<Campaign, object>(x=>x.Name as object)">Name</MudTableSortLabel>
//                 </MudTh>
//                 <MudTh>
//                     <MudTableSortLabel SortBy="new Func<Campaign, object>(x=>x.Description as object)">Description</MudTableSortLabel>
//                 </MudTh>
//                 <MudTh>
//                     <MudTableSortLabel SortBy="new Func<Campaign, object>(x=>x.StartDate as object)">Start Date</MudTableSortLabel>
//                 </MudTh>
//                 <MudTh>
//                     <MudTableSortLabel SortBy="new Func<Campaign, object>(x=>x.EndDate as object)">End Date</MudTableSortLabel>
//                 </MudTh>
//                 <MudTh>
//                     <MudTableSortLabel SortBy="new Func<Campaign, object>(x=>x.Budget as object)">Budget</MudTableSortLabel>
//                 </MudTh>
//                 <MudTh>
//                     <MudTableSortLabel SortBy="new Func<Campaign, object>(x=>x.Status as object)">Status</MudTableSortLabel>
//                 </MudTh>
//                 <MudTh>
//                     <MudTableSortLabel SortBy="new Func<Campaign, object>(x=>x.Type as object)">Type</MudTableSortLabel>
//                 </MudTh>
//                 <MudTh Style="text-align:center">Actions</MudTh>
//             </HeaderContent>
//             <RowTemplate>
//                 <MudTd DataLabel="Id">@context.Id</MudTd>
//                 <MudTd DataLabel="Name">@context.Name</MudTd>
//                 <MudTd DataLabel="Description">
//                     <MudTooltip Text="@context.Description" Color="Color.Primary">
//                         <span>@(context.Description?.Length > 30 ? context.Description.Substring(0, 30) + "..." : context.Description)</span>
//                     </MudTooltip>
//                 </MudTd>
//                 <MudTd DataLabel="Start Date">
//                     <MudChip T="string" Size="Size.Small" Color="Color.Info">@context.StartDate.ToShortDateString()</MudChip>
//                 </MudTd>
//                 <MudTd DataLabel="End Date">
//                     <MudChip T="string" Size="Size.Small" Color="Color.Info">@context.EndDate.ToShortDateString()</MudChip>
//                 </MudTd>
//                 <MudTd DataLabel="Budget">
//                     <MudText Typo="Typo.body2" Color="Color.Success">$@context.Budget</MudText>
//                 </MudTd>
//                 <MudTd DataLabel="Status">
//                     <MudChip T="string" Color="@GetStatusColor(@context.Status)" Text="@context.Status" Icon="@Icons.Material.Filled.Done" />
//                 </MudTd>
//                 <MudTd DataLabel="Type">
//                     <MudChip T="string" Size="Size.Small" Color="Color.Secondary">@context.Type</MudChip>
//                 </MudTd>
//                 <MudTd DataLabel="Actions" Style="text-align:center">
//                     <MudStack Row="true" Spacing="2" Justify="Justify.Center">
//                         <MudButton Href="@string.Format("/Campaigns/{0}", context.Id)" 
//                                    Variant="Variant.Filled" 
//                                    Color="Color.Primary" 
//                                    Size="Size.Small"
//                                    StartIcon="@Icons.Material.Filled.MoreHoriz">
//                             View
//                         </MudButton>
//                         <MudButton Href="@string.Format("/Campaigns/edit/{0}", context.Id)" 
//                                    Variant="Variant.Filled" 
//                                    Color="Color.Warning" 
//                                    Size="Size.Small"
//                                    StartIcon="@Icons.Material.Filled.Edit">
//                             Edit
//                         </MudButton>
//                     </MudStack>
//                 </MudTd>
//             </RowTemplate>
//         </MudTable>
//     </MudPaper>
// </MudContainer>