using Microsoft.VisualStudio.TestTools.UnitTesting;
using Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class Step1_FallingBlocksTest
    {
        Board board;

        [TestInitialize]
        public void SetUp()
        {
            board = new Board(3, 3);
        }

        #region when_a_new_board_is_created

        [TestMethod]
        public void board_is_empty()
        {
            Assert.AreEqual(board.ToString(),
                "...\n" +
                "...\n" +
                "...\n"
            );
        }
        [TestMethod]
        public void board_has_no_falling_blocks()
        {
            Assert.IsFalse(board.IsFallingBlock());
        }

        #endregion

        #region when_a_block_is_dropped

        void DropBlock(char c)
        {
            board.Drop(new Block(c));
        }
        [TestMethod]
        public void block_is_falling()
        {
            //  act
            DropBlock('X');

            // assert
            Assert.IsTrue(board.IsFallingBlock());
        }
// I NEED YOUUUU !!!
        [TestMethod]
        public void block_starts_from_the_top_middle()
        {
            //    // act
            DropBlock('X');

            // assert
            Assert.AreEqual(board.ToString(),
                 ".X.\n" +
                 "...\n" +
                 "...\n"
             );
        }

        [TestMethod]
        public void block_moves_down_one_row_per_tick()
        {
            // arrange
            DropBlock('X');

            // act
            board.Tick();

            // assert
            Assert.AreEqual(board.ToString(),
                "...\n" +
                ".X.\n" +
                 "...\n"
            );
            //}

            //[TestMethod]
            //[ExpectedException(typeof(ArgumentException), "A block is already falling.")]
            //public void at_most_one_block_may_be_falling_at_a_time()
            //{
            //    // arrange
            //    DropBlock('X');

            //    // act
            //    DropBlock('Y');

            //    // assert
            //    Assert.AreEqual(board.ToString(),
            //        ".X.\n" +
            //        "...\n" +
            //        "...\n"
            //    );
            //}

            #endregion

            #region when_a_block_reaches_the_bottom

            //void FallToLastRow()
            //{
            //    DropBlock('X');
            //    board.Tick();
            //    board.Tick();
            //}

            //[TestMethod]
            //public void block_moves_to_the_last_row()
            //{
            //    // act
            //    FallToLastRow();

            //    // assert
            //    Assert.AreEqual(board.ToString(),
            //        "...\n" +
            //        "...\n" +
            //        ".X.\n"
            //    );
            //}

            //[TestMethod]
            //public void block_is_still_falling_on_the_last_row()
            //{
            //    // act
            //    FallToLastRow();

            //    // assert
            //    Assert.IsTrue(board.IsFallingBlock());
            //}

            //[TestMethod]
            //public void block_stops_moving_when_it_hits_the_bottom()
            //{
            //    // arrange
            //    FallToLastRow();

            //    // act
            //    board.Tick();

            //    // assert
            //    Assert.AreEqual(board.ToString(),
            //        "...\n" +
            //        "...\n" +
            //        ".X.\n"
            //    );
            //}

            //[TestMethod]
            //public void block_stops_falling_when_it_hits_the_bottom()
            //{
            //    // arrange
            //    FallToLastRow();

            //    // act
            //    board.Tick();

            //    // assert
            //    Assert.IsFalse(board.IsFallingBlock());
            //}

            #endregion

            #region when_a_block_lands_on_another_block

            //void DropBlockAfterBlock()
            //{
            //    DropBlock('X');
            //    board.Tick();
            //    board.Tick();
            //    board.Tick();
            //    DropBlock('Y');
            //    board.Tick();
            //}

            //[TestMethod]
            //public void block_is_still_falling_right_above_the_other_block()
            //{
            //    // act
            //    DropBlockAfterBlock();

            //    // assert
            //    Assert.AreEqual(board.ToString(),
            //        "...\n" +
            //        ".Y.\n" +
            //        ".X.\n"
            //    );
            //    Assert.IsTrue(board.IsFallingBlock());
            //}

            //[TestMethod]
            //public void block_stops_when_it_hits_the_other_block()
            //{
            //    // arrange
            //    DropBlockAfterBlock();

            //    // act
            //    board.Tick();

            //    // assert
            //    Assert.AreEqual(board.ToString(),
            //        "...\n" +
            //        ".Y.\n" +
            //        ".X.\n"
            //    );
            //    Assert.IsFalse(board.IsFallingBlock());
            //}

            #endregion
        }
    }
}
