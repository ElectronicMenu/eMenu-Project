<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="Electronic_Menu.User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <asp:GridView ID="GridViewUser" runat="server" AutoGenerateColumns="False" Font-Names="Verdana"
            AllowPaging="true" ShowFooter="true" PageSize="5" Width="75%"
            BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" 
        DataKeyNames="user_id" onrowediting="GridViewUser_RowEditing" OnPageIndexChanging="GridViewUser_PageIndexChanging"
    onrowcommand="GridViewUser_RowCommand" 
    onrowdeleting="GridViewUser_RowDeleting" OnRowCancelingEdit ="GridViewUser_RowCancelEditing" OnRowUpdating="GridViewUser_RowUpdating">

                   <AlternatingRowStyle BackColor="#FFD4BA" />
            <FooterStyle Height="20px" Font-Size="15px" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" />
            <PagerStyle BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" />
            <HeaderStyle Height="30px" BackColor="#FF9E66" Font-Size="15px" BorderColor="#CCCCCC"
                BorderStyle="Solid" BorderWidth="1px" />
            <RowStyle Height="20px" Font-Size="13px" BorderColor="#CCCCCC" BorderStyle="Solid"
                BorderWidth="1px" />
            <Columns>

                <asp:TemplateField HeaderText="User ID" Visible="false" HeaderStyle-Width="10%" >
                    <ItemTemplate>
                        <asp:Label ID="lblUserID" DataField="user_id" runat="server" Text='<%#Eval("user_id") %>'></asp:Label>
                    </ItemTemplate>
                      <EditItemTemplate>
                        <asp:TextBox ID="txtEditUserID" runat="server" Text='<%#Eval("user_id") %>' ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqId" ValidationGroup="ValgrpCust" ControlToValidate="txtEditUserID" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <FooterTemplate>
                         <asp:TextBox ID="txtAddUserID" runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="reqAddID" ValidationGroup="ValgrpCust" ControlToValidate="txtAddUserID" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:Label ID="lbladd" runat="server"></asp:Label>
                    </FooterTemplate>
                </asp:TemplateField>




                

                <asp:TemplateField HeaderText="Username" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <asp:Label ID="lbluser_username" runat="server" Text='<%#Eval("user_username") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEditUserName" runat="server" Text='<%#Eval("user_username") %>' ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqEditUserName" ValidationGroup="ValgrpCust" ControlToValidate="txtEditUserName" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>

                    <FooterTemplate>
                        <asp:TextBox ID="txtAddUserName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqAddUserName" ValidationGroup="ValgrpCust" ControlToValidate="txtAddUserName" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                    <HeaderStyle Width="15%"></HeaderStyle>
                </asp:TemplateField>



                <asp:TemplateField HeaderText="First Name" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <asp:Label ID="lblcategory_icon" runat="server" Text='<%#Eval("user_first_name") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEditFirstName" runat="server" Text='<%#Eval("user_first_name") %>' ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqEditName" ValidationGroup="ValgrpCust" ControlToValidate="txtEditFirstName" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
        
                    </EditItemTemplate>

                    <FooterTemplate>
                        <asp:TextBox ID="txtAddfirstName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqAddName" ValidationGroup="ValgrpCust" ControlToValidate="txtAddfirstName" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                    <HeaderStyle Width="15%"></HeaderStyle>
                </asp:TemplateField>



                <asp:TemplateField HeaderText="Last Name" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <asp:Label ID="lbluser_last_name" runat="server" Text='<%#Eval("user_last_name") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEdituser_last_name" runat="server" Text='<%#Eval("user_last_name") %>' ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqEdituser_last_name" ValidationGroup="ValgrpCust" ControlToValidate="txtEdituser_last_name" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
        
                    </EditItemTemplate>

                    <FooterTemplate>
                        <asp:TextBox ID="txtAdduser_last_name" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqAdduser_last_name" ValidationGroup="ValgrpCust" ControlToValidate="txtAdduser_last_name" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                    <HeaderStyle Width="15%"></HeaderStyle>
                </asp:TemplateField>



                 <asp:TemplateField HeaderText="User Password" HeaderStyle-Width="7%">
                    <ItemTemplate>
                        <asp:Label ID="lbluser_password" runat="server" Text='<%#Eval("user_password") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEdituser_password" runat="server" Text='<%#Eval("user_password") %>' ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqEditUserID" ValidationGroup="ValgrpCust" ControlToValidate="txtEdituser_password" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
        
                    </EditItemTemplate>

                    <FooterTemplate>
                        <asp:TextBox ID="txtAdduser_password" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqAddUserID" ValidationGroup="ValgrpCust" ControlToValidate="txtAdduser_password" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                    <HeaderStyle Width="10%"></HeaderStyle>
                </asp:TemplateField>


                <asp:TemplateField HeaderText="Gender" HeaderStyle-Width="7%">
                    <ItemTemplate>
                        <asp:Label ID="lbluser_genderd" runat="server" Text='<%#Eval("user_gender") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEdituser_gender" runat="server" Text='<%#Eval("user_gender") %>' ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqEditUserGender" ValidationGroup="ValgrpCust" ControlToValidate="txtEdituser_gender" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
        
                    </EditItemTemplate>

                    <FooterTemplate>
                        <asp:TextBox ID="txtAdduser_gender" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqAddUserGender" ValidationGroup="ValgrpCust" ControlToValidate="txtAdduser_gender" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                    <HeaderStyle Width="10%"></HeaderStyle>
                </asp:TemplateField>
           

                <asp:TemplateField HeaderText="Email" HeaderStyle-Width="7%">
                    <ItemTemplate>
                        <asp:Label ID="lbluser_email" runat="server" Text='<%#Eval("user_email") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEdituser_email" runat="server" Text='<%#Eval("user_email") %>' ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqEditUserGender" ValidationGroup="ValgrpCust" ControlToValidate="txtEdituser_password" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
        
                    </EditItemTemplate>

                    <FooterTemplate>
                        <asp:TextBox ID="txtAdduser_email" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqAdduser_email" ValidationGroup="ValgrpCust" ControlToValidate="txtAdduser_email" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                    <HeaderStyle Width="10%"></HeaderStyle>
                </asp:TemplateField>



                <asp:TemplateField HeaderText="Phone" HeaderStyle-Width="7%">
                    <ItemTemplate>
                        <asp:Label ID="lbluser_phone" runat="server" Text='<%#Eval("user_phone") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEdituser_phone" runat="server" Text='<%#Eval("user_phone") %>' ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqEdituser_phoner" ValidationGroup="ValgrpCust" ControlToValidate="txtEdituser_phone" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
        
                    </EditItemTemplate>

                    <FooterTemplate>
                        <asp:TextBox ID="txtAdduser_phone" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqAdduser_phone" ValidationGroup="ValgrpCust" ControlToValidate="txtAdduser_phone" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                    <HeaderStyle Width="10%"></HeaderStyle>
                </asp:TemplateField>

                
                 <asp:TemplateField HeaderText="Email Verified" HeaderStyle-Width="7%">
                    <ItemTemplate>
                        <asp:Label ID="lbluser_email_verified" runat="server" Text='<%#Eval("user_email_verified") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:CheckBox ID="chk_user_email_verified" runat="server" />
                   
                    </EditItemTemplate>

                    <FooterTemplate>
                       <asp:CheckBox ID="chkAdd_user_email_verified" runat="server" />
                                  </FooterTemplate>
                    <HeaderStyle Width="10%"></HeaderStyle>
                </asp:TemplateField>



                
                 <asp:TemplateField HeaderText="Registration Date" HeaderStyle-Width="7%">
                    <ItemTemplate>
                        <asp:Label ID="lbluser_registration_date" runat="server" Text='<%#Eval("user_registration_date") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEdituser_registration_date" runat="server" Text='<%#Eval("user_registration_date") %>' ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqEdituser_registration_date" ValidationGroup="ValgrpCust" ControlToValidate="txtEdituser_registration_date" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
        
                    </EditItemTemplate>

                    <FooterTemplate>
                        <asp:TextBox ID="txtAdduser_registration_date" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqAdduser_registration_date" ValidationGroup="ValgrpCust" ControlToValidate="txtAdduser_registration_date" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                    <HeaderStyle Width="10%"></HeaderStyle>
                </asp:TemplateField>

                

                <asp:TemplateField HeaderText="Verification Code" HeaderStyle-Width="7%">
                    <ItemTemplate>
                        <asp:Label ID="lbluser_verification_code" runat="server" Text='<%#Eval("user_verification_code") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEdituser_verification_code" runat="server" Text='<%#Eval("user_verification_code") %>' ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqEdituser_registration_date" ValidationGroup="ValgrpCust" ControlToValidate="txtEdituser_verification_code" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
        
                    </EditItemTemplate>

                    <FooterTemplate>
                        <asp:TextBox ID="txtAdduser_verification_codee" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqAdduser_verification_code" ValidationGroup="ValgrpCust" ControlToValidate="txtAdduser_verification_codee" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                    <HeaderStyle Width="10%"></HeaderStyle>
                </asp:TemplateField>


                <asp:TemplateField HeaderText="Date of Birth" HeaderStyle-Width="7%">
                    <ItemTemplate>
                        <asp:Label ID="lbluser_date_of_birth" runat="server" Text='<%#Eval("user_date_of_birth") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEdituser_date_of_birth" runat="server" Text='<%#Eval("user_date_of_birth") %>' ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqEdituser_date_of_birth" ValidationGroup="ValgrpCust" ControlToValidate="txtEdituser_date_of_birth" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
        
                    </EditItemTemplate>

                    <FooterTemplate>
                        <asp:TextBox ID="txtAdduser_date_of_birth" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqAdduser_date_of_birth" ValidationGroup="ValgrpCust" ControlToValidate="txtAdduser_date_of_birth" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                    <HeaderStyle Width="10%"></HeaderStyle>
                </asp:TemplateField>



                <asp:TemplateField HeaderText="Country" HeaderStyle-Width="7%">
                    <ItemTemplate>
                        <asp:Label ID="lbluser_country_id" runat="server" Text='<%#Eval("country_id") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEdituser_country_id" runat="server" Text='<%#Eval("country_id") %>' ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqEdituser_country_id" ValidationGroup="ValgrpCust" ControlToValidate="txtEdituser_country_id" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
        
                    </EditItemTemplate>

                    <FooterTemplate>
                        <asp:TextBox ID="txtAdduser_country_id" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqAdduser_country_id" ValidationGroup="ValgrpCust" ControlToValidate="txtAdduser_country_id" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                    <HeaderStyle Width="10%"></HeaderStyle>
                </asp:TemplateField>



                <asp:TemplateField HeaderText="Edit/Delete" HeaderStyle-Width="15%">
                    <ItemTemplate>
                        <center>
                       <%-- <asp:LinkButton ID="btnEdit" Text="Edit" runat="server" CommandName="Edit" />--%>
                        <asp:ImageButton ID="btnEdit" ImageUrl="~/images/edit.png" CommandName="Edit" runat="server" />
               
                        <span onclick="return confirm('Are you sure want to delete?')">
                           <%-- <asp:LinkButton ID="btnDelete" Text="Delete" runat="server" CommandName="Delete" />--%>
                            <asp:ImageButton ID="btnDelete" ImageUrl="~/images/delete.png" CommandName="Delete" runat="server" />
                        </span>
                            </center>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <center>
                       <%-- <asp:LinkButton ID="btnUpdate" Text="Update" runat="server" CommandName="Update" />--%>
                         <asp:ImageButton ID="btnUpdate" ImageUrl="~/images/update.png" CommandName="Update" runat="server" />
                   
                      <%--  <asp:LinkButton ID="btnCancel" Text="Cancel" runat="server" CommandName="Cancel" />--%>
                         <asp:ImageButton ID="btnCancel" ImageUrl="~/images/cancel.png" CommandName="Cancel" runat="server" />
                   </center>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <%--<asp:Button ID="btnInsertRecord" runat="server" Text="Add" CommandName="Insert" />--%>
                     <center> <asp:ImageButton ID="btnInsertRecord" ImageUrl="~/images/add.png" CommandName="Insert" runat="server" /></center>
                    </FooterTemplate>
                    <HeaderStyle Width="15%"></HeaderStyle>
                </asp:TemplateField>


            </Columns>
        </asp:GridView>

</asp:Content>
