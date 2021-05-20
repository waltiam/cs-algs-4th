﻿using Floatingman.Common.Functional;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Floatingman.Collections.Test
{
    public class ReverseExtensionTests
    {
        [Fact]
        public void Can_Reverse_Many()
        {
            var input = new[] { 'a', 'b', 'c', 'd', 'e' };
            var output = new[] { 'e', 'd', 'c', 'b', 'a' };
            var stack = new Stack<char>(input);
            stack.Reverse().Should().ContainInOrder(output);
        }

        [Fact]
        public void Can_Reverse_None()
        {
            var input = new char[] { };
            var output = new char[] { };
            var stack = new Stack<char>(input);
            stack.Reverse().Should().ContainInOrder(output);
        }

        [Fact]
        public void Can_Reverse_One()
        {
            var input = new[] { 'a' };
            var output = new[] { 'a' };
            var stack = new Stack<char>(input);
            stack.Reverse().Should().ContainInOrder(output);
        }

        [Fact]
        public void Can_Reverse_Two()
        {
            var input = new[] { 'a', 'b' };
            var output = new[] { 'b', 'a' };
            var stack = new Stack<char>(input);
            stack.Reverse().Should().ContainInOrder(output);
        }
    }
}