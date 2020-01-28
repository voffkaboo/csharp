﻿using System;
using OpenQA.Selenium;

namespace WebAddressBookTests
{
    public class GroupHelper : HelperBase
    {
        public GroupHelper (AppManager manager) : base(manager)
        {
        }
        public GroupHelper Create(GroupData data)
        {
            manager.Navigator.GoToGroupsPage();
            InitGroupCreation();
            FillGroupForms(data);
            SubmitGroupCreation();
            return this;
        }

        internal GroupHelper Modify(int groupIndex, GroupData modifyData)
        {
            manager.Navigator.GoToGroupsPage();
            SelectGroup(groupIndex);
            InitGroupModification();
            FillGroupForms(modifyData);
            SubmitGroupModification();
            manager.Navigator.GoToGroupsPage();
            return this;
        }

        public GroupHelper SubmitGroupModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public GroupHelper InitGroupModification()
        {
            driver.FindElement(By.Name("edit")).Click();
            return this;
        }

        public GroupHelper RemoveGroup(int groupIndex)
        {
            manager.Navigator.GoToGroupsPage();
            SelectGroup(groupIndex);
            RemoveGroup();
            return this;
        }

        public GroupHelper InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }
        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public GroupHelper FillGroupForms(GroupData group)
        {
            FillFieldOnlyIfDataExists(By.Name("group_name"), group.Name);
            FillFieldOnlyIfDataExists(By.Name("group_header"), group.Header);
            FillFieldOnlyIfDataExists(By.Name("group_footer"), group.Footer);
            
            return this;
        }

        public GroupHelper SelectGroup(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            return this;
        }
        public GroupHelper RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
            return this;
        }
    }
}
