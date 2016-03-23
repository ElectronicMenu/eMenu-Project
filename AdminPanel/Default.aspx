<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Emenu.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>


             <script src="http://ajax.googleapis.com/ajax/libs/jquery/1/jquery.min.js"></script>
        <script>
       
        </script> 
</head>
<body>

    
    <form id="form1" runat="server">
    <div>
    
        
          <asp:GridView ID="GridViewCategory" runat="server" AutoGenerateColumns="False" Font-Names="Verdana"
            AllowPaging="true" ShowFooter="true" PageSize="5" Width="75%"
            BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" 
        DataKeyNames="category_id" onrowediting="GridViewCategory_RowEditing" 
    onrowcommand="GridViewCategory_RowCommand" 
    onrowdeleting="GridViewCategory_RowDeleting" OnRowCancelingEdit ="GridViewCategory_RowCancelEditing" OnRowUpdating="GridViewCategory_RowUpdating">

                   <AlternatingRowStyle BackColor="#FFD4BA" />
            <FooterStyle BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" />
            <PagerStyle BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" />
            <HeaderStyle Height="30px" BackColor="#FF9E66" Font-Size="15px" BorderColor="#CCCCCC"
                BorderStyle="Solid" BorderWidth="1px" />
            <RowStyle Height="20px" Font-Size="13px" BorderColor="#CCCCCC" BorderStyle="Solid"
                BorderWidth="1px" />
            <Columns>

                <asp:TemplateField HeaderText="Category ID" Visible="false" HeaderStyle-Width="10%" >
                    <ItemTemplate>
                        <asp:Label ID="lblcategoryID" DataField="category_id" runat="server" Text='<%#Eval("category_id") %>'></asp:Label>
                    </ItemTemplate>
                      <EditItemTemplate>
                        <asp:TextBox ID="txtEditCategoryID" runat="server" Text='<%#Eval("category_id") %>' ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqId" ValidationGroup="ValgrpCust" ControlToValidate="txtEditCategoryID" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <FooterTemplate>
                         <asp:TextBox ID="txtAddCategoryID" runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="reqAddID" ValidationGroup="ValgrpCust" ControlToValidate="txtAddCategoryID" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:Label ID="lbladd" runat="server"></asp:Label>
                    </FooterTemplate>
                </asp:TemplateField>




                

                <asp:TemplateField HeaderText="Category Image" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <asp:Label ID="lblcategory_name" runat="server" Text='<%#Eval("category_image") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEditCategoryImage" runat="server" Text='<%#Eval("category_image") %>' ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqImage" ValidationGroup="ValgrpCust" ControlToValidate="txtEditCategoryIcon" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>

                    <FooterTemplate>
                        <asp:TextBox ID="txtAddCategoryImage" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqAddImage" ValidationGroup="ValgrpCust" ControlToValidate="txtAddCategoryImage" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                    <HeaderStyle Width="15%"></HeaderStyle>
                </asp:TemplateField>




                

                <asp:TemplateField HeaderText="Category Icon" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <asp:Label ID="lblcategory_icon" runat="server" Text='<%#Eval("category_icon") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEditCategoryIcon" runat="server" Text='<%#Eval("category_icon") %>' ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqAddIcon" ValidationGroup="ValgrpCust" ControlToValidate="txtEditCategoryIcon" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
        
                    </EditItemTemplate>

                    <FooterTemplate>
                        <asp:TextBox ID="txtAddCategoryIcon" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqIcon" ValidationGroup="ValgrpCust" ControlToValidate="txtAddCategoryIcon" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                    <HeaderStyle Width="15%"></HeaderStyle>
                </asp:TemplateField>




           
                
                <asp:TemplateField HeaderText="Edit/Delete" HeaderStyle-Width="15%">
                    <ItemTemplate>
                        <asp:LinkButton ID="btnEdit" Text="Edit" runat="server" CommandName="Edit" />
                        <span onclick="return confirm('Are you sure want to delete?')">
                            <asp:LinkButton ID="btnDelete" Text="Delete" runat="server" CommandName="Delete" />
                        </span>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:LinkButton ID="btnUpdate" Text="Update" runat="server" CommandName="Update" />
                        <asp:LinkButton ID="btnCancel" Text="Cancel" runat="server" CommandName="Cancel" />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:Button ID="btnInsertRecord" runat="server" Text="Add" CommandName="Insert" />
                    </FooterTemplate>
                    <HeaderStyle Width="15%"></HeaderStyle>
                </asp:TemplateField>


            </Columns>
        </asp:GridView>



         


    </div>
    </form>
</body>
</html>
