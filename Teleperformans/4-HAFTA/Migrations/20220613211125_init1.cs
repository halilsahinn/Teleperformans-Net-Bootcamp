using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _4_Odev.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MessageType,User",
                table: "MessageType,User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages,User",
                table: "Messages,User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MessageHistory,User",
                table: "MessageHistory,User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupMessages,User",
                table: "GroupMessages,User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Friends,User",
                table: "Friends,User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FriendConfirmation,User",
                table: "FriendConfirmation,User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments,User",
                table: "Comments,User");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AspNetUsers");

            migrationBuilder.EnsureSchema(
                name: "User");

            migrationBuilder.RenameTable(
                name: "MessageType,User",
                newName: "MessageType",
                newSchema: "User");

            migrationBuilder.RenameTable(
                name: "Messages,User",
                newName: "Messages",
                newSchema: "User");

            migrationBuilder.RenameTable(
                name: "MessageHistory,User",
                newName: "MessageHistory",
                newSchema: "User");

            migrationBuilder.RenameTable(
                name: "GroupMessages,User",
                newName: "GroupMessages",
                newSchema: "User");

            migrationBuilder.RenameTable(
                name: "Friends,User",
                newName: "Friends",
                newSchema: "User");

            migrationBuilder.RenameTable(
                name: "FriendConfirmation,User",
                newName: "FriendConfirmation",
                newSchema: "User");

            migrationBuilder.RenameTable(
                name: "Comments,User",
                newName: "Comments",
                newSchema: "User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MessageType",
                schema: "User",
                table: "MessageType",
                column: "MessageTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Messages",
                schema: "User",
                table: "Messages",
                column: "MessageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MessageHistory",
                schema: "User",
                table: "MessageHistory",
                column: "MessageHistoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupMessages",
                schema: "User",
                table: "GroupMessages",
                column: "GroupMessagesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Friends",
                schema: "User",
                table: "Friends",
                column: "UserFriendId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FriendConfirmation",
                schema: "User",
                table: "FriendConfirmation",
                column: "FriendConfirmationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                schema: "User",
                table: "Comments",
                column: "CommentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MessageType",
                schema: "User",
                table: "MessageType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages",
                schema: "User",
                table: "Messages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MessageHistory",
                schema: "User",
                table: "MessageHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupMessages",
                schema: "User",
                table: "GroupMessages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Friends",
                schema: "User",
                table: "Friends");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FriendConfirmation",
                schema: "User",
                table: "FriendConfirmation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                schema: "User",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "MessageType",
                schema: "User",
                newName: "MessageType,User");

            migrationBuilder.RenameTable(
                name: "Messages",
                schema: "User",
                newName: "Messages,User");

            migrationBuilder.RenameTable(
                name: "MessageHistory",
                schema: "User",
                newName: "MessageHistory,User");

            migrationBuilder.RenameTable(
                name: "GroupMessages",
                schema: "User",
                newName: "GroupMessages,User");

            migrationBuilder.RenameTable(
                name: "Friends",
                schema: "User",
                newName: "Friends,User");

            migrationBuilder.RenameTable(
                name: "FriendConfirmation",
                schema: "User",
                newName: "FriendConfirmation,User");

            migrationBuilder.RenameTable(
                name: "Comments",
                schema: "User",
                newName: "Comments,User");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MessageType,User",
                table: "MessageType,User",
                column: "MessageTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Messages,User",
                table: "Messages,User",
                column: "MessageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MessageHistory,User",
                table: "MessageHistory,User",
                column: "MessageHistoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupMessages,User",
                table: "GroupMessages,User",
                column: "GroupMessagesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Friends,User",
                table: "Friends,User",
                column: "UserFriendId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FriendConfirmation,User",
                table: "FriendConfirmation,User",
                column: "FriendConfirmationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments,User",
                table: "Comments,User",
                column: "CommentId");
        }
    }
}
