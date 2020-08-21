namespace alkemyUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.course",
                c => new
                {
                    course_id = c.Long(nullable: false, identity: true),
                    max_student_quota = c.Short(nullable: false),
                    lecturer_id = c.Long(nullable: false),
                    student_id = c.Long(nullable: false),
                })
                .PrimaryKey(t => t.course_id)
                .ForeignKey("dbo.lecturer", t => t.lecturer_id)
                .Index(t => t.course_id);

            CreateTable(
                "dbo.person",
                c => new
                {
                    person_id = c.Long(nullable: false, identity: true),
                    User = c.String(),
                    Password = c.String(),
                    first_name = c.String(),
                    last_name = c.String(),
                })
                .PrimaryKey(t => t.person_id);

            CreateTable(
                "dbo.student_courses",
                c => new
                {
                    student_id = c.Long(nullable: false),
                    course_id = c.Long(nullable: false),
                })
                .PrimaryKey(t => new { t.student_id, t.course_id })
                .ForeignKey("dbo.student", t => t.student_id, cascadeDelete: true)
                .ForeignKey("dbo.course", t => t.course_id, cascadeDelete: true)
                .Index(t => t.student_id)
                .Index(t => t.course_id);

            CreateTable(
                "dbo.employee",
                c => new
                {
                    person_id = c.Long(nullable: false),
                    employee_id = c.Long(nullable: false),
                    identification_number = c.Long(nullable: false),
                    Email = c.String(),
                    Country = c.String(),
                    State = c.String(),
                    City = c.String(),
                    is_admin = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.person_id)
                .ForeignKey("dbo.person", t => t.person_id)
                .Index(t => t.person_id);

            CreateTable(
                "dbo.lecturer",
                c => new
                {
                    person_id = c.Long(nullable: false),
                    lecturer_id = c.Long(nullable: false),
                    is_active = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.person_id)
                .ForeignKey("dbo.employee", t => t.person_id)
                .Index(t => t.person_id);

            CreateTable(
                "dbo.student",
                c => new
                {
                    person_id = c.Long(nullable: false),
                    student_id = c.Long(nullable: false),
                    Bundle = c.Long(nullable: false),
                })
                .PrimaryKey(t => t.person_id)
                .ForeignKey("dbo.person", t => t.person_id)
                .Index(t => t.person_id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.student", "person_id", "dbo.person");
            DropForeignKey("dbo.lecturer", "person_id", "dbo.employee");
            DropForeignKey("dbo.employee", "person_id", "dbo.person");
            DropForeignKey("dbo.StudentCourses", "Course_CourseId", "dbo.course");
            DropForeignKey("dbo.StudentCourses", "Student_PersonId", "dbo.student");
            DropForeignKey("dbo.course", "lecturer_id", "dbo.lecturer");
            DropIndex("dbo.student", new[] { "person_id" });
            DropIndex("dbo.lecturer", new[] { "person_id" });
            DropIndex("dbo.employee", new[] { "person_id" });
            DropIndex("dbo.StudentCourses", new[] { "Course_CourseId" });
            DropIndex("dbo.StudentCourses", new[] { "Student_PersonId" });
            DropIndex("dbo.course", new[] { "course_id" });
            DropTable("dbo.student");
            DropTable("dbo.lecturer");
            DropTable("dbo.employee");
            DropTable("dbo.StudentCourses");
            DropTable("dbo.person");
            DropTable("dbo.course");
        }
    }
}
