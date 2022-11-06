import { useGlobalFilter, useFilters, useSortBy, useTable, usePagination } from 'react-table'
import InfiniteScroll from 'react-infinite-scroll-component'
import {
  CButtonGroup,
  CCol,
  CDropdown,
  CDropdownItem,
  CDropdownItemPlain,
  CDropdownMenu,
  CDropdownToggle,
  CFormInput,
  CFormLabel,
  CFormSelect,
  CPagination,
  CPaginationItem,
  CRow,
  CTable,
  CTableBody,
  CTableDataCell,
  CTableHead,
  CTableHeaderCell,
  CTableRow,
} from '@coreui/react'
import React from 'react'
import { useDispatch } from 'react-redux'
// eslint-disable-next-line react/prop-types
function TableOffer({ columns, data }) {
  // eslint-disable-next-line react-hooks/rules-of-hooks

  const dispath = useDispatch()
  const {
    getTableProps,
    getTableBodyProps,
    headerGroups,
    page,
    prepareRow,
    state,
    visibleColumns,
    setGlobalFilter,
    preGlobalFilteredRows,
    allColumns,
    nextPage,
    previousPage,
    canNextPage,
    canPreviousPage,
    pageOptions,
    gotoPage,
    setPageSize,
    pageCount,
    rows,
    state: { pageIndex, pageSize },
  } = useTable(
    {
      columns,
      data,
      initialState: { pageIndex: 0, pageSize: 25 },
    },
    useGlobalFilter,
    useFilters,
    useSortBy,
    usePagination,
  )

  var pageSizeM = pageSize
  const fetchData = () => {
    pageSizeM += 25
    setPageSize(pageSizeM)
    console.log(pageSizeM)
  }

  return (
    <>
      <CRow className={'mb-3'}></CRow>
      <InfiniteScroll
        dataLength={page.length}
        hasMore={true}
        loader={<h4>Loading...</h4>}
        next={fetchData}
      >
        <CTable bordered {...getTableProps()} className={'selectTable'}>
          <CTableHead>
            {headerGroups.map((headerGroup) => (
              // eslint-disable-next-line react/jsx-key
              <CTableRow {...headerGroup.getHeaderGroupProps()}>
                {headerGroup.headers.map((column) => (
                  // eslint-disable-next-line react/jsx-key
                  <CTableHeaderCell scope="col" {...column.getHeaderProps()}>
                    <div {...column.getHeaderProps(column.getSortByToggleProps())}>
                      {column.render('Header')}
                      <span>{column.isSorted ? (column.isSortedDesc ? ' 🔽' : ' 🔼') : ''}</span>
                    </div>
                    {/*<div>{column.canFilter ? column.render('Filter') : null}</div>*/}
                  </CTableHeaderCell>
                ))}
              </CTableRow>
            ))}
          </CTableHead>
          <CTableBody {...getTableBodyProps()}>
            {page.map((row, i) => {
              prepareRow(row)
              return (
                // eslint-disable-next-line react/jsx-key
                <CTableRow className={'link'} scope="row" {...row.getRowProps()}>
                  {row.cells.map((cell) => {
                    return (
                      // eslint-disable-next-line react/jsx-key
                      <CTableDataCell {...cell.getCellProps()}>
                        {cell.render('Cell')}
                      </CTableDataCell>
                    )
                  })}
                </CTableRow>
              )
            })}
          </CTableBody>
        </CTable>
      </InfiniteScroll>
      {/* <CRow className="mb-auto">
        <CFormLabel htmlFor={'selectStorage'} className="col-sm-auto col-form-label">
          <span>
            Страница{' '}
            <strong>
              {pageIndex + 1} из {pageOptions.length}
            </strong>{' '}
            | Перейти на страницу:
          </span>
        </CFormLabel>
        <div className="col-sm-1">
          <CFormInput
            type="number"
            id="inputSearch"
            placeholder={`Поиск среди  строк`}
            defaultValue={pageIndex + 1}
            onChange={(e) => {
              const pageNumber = e.target.value ? Number(e.target.value) - 1 : 0
              gotoPage(pageNumber)
            }}
          />
        </div>
        <div className="col-sm-auto">
          <CFormSelect value={pageSize} onChange={(e) => setPageSize(Number(e.target.value))}>
            {[25, 50, 75, 100].map((pageSize) => (
              <option key={pageSize} value={pageSize}>
                Показать {pageSize}
              </option>
            ))}
          </CFormSelect>
        </div>
        <div className="col-sm-auto float-end">
          <CPagination align="end" aria-label="Навигация">
            <CPaginationItem onClick={() => gotoPage(0)} disabled={!canPreviousPage}>
              {'<<'}
            </CPaginationItem>
            <CPaginationItem onClick={() => previousPage()} disabled={!canPreviousPage}>
              Прошлая
            </CPaginationItem>
            <CPaginationItem onClick={() => nextPage()} disabled={!canNextPage}>
              Следующая
            </CPaginationItem>
            <CPaginationItem onClick={() => gotoPage(pageCount - 1)} disabled={!canNextPage}>
              {'>>'}
            </CPaginationItem>
          </CPagination>
        </div>
      </CRow> */}
    </>
  )
}

export default TableOffer
